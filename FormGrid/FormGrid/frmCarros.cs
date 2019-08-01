using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FormGrid.Adicionar;

namespace FormGrid
{
    public partial class frmCarros : Form
    {
        public frmCarros()
        {
            InitializeComponent();
        }
        
        private void FrmCarros_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bancoDeDadosinnerJoinDataSet1.Carros' table. You can move, or remove it, as needed.
            this.carrosTableAdapter1.CustomQuery(this.bancoDeDadosinnerJoinDataSet1.Carros);
           
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            frmMarcas marcas = new frmMarcas();
            marcas.ShowDialog();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            frmVendas vendas = new frmVendas();
            vendas.ShowDialog();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Usuarios usuarios = new Usuarios();
            usuarios.ShowDialog();

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var carSelect = ((DataRowView) this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
                           as FormGrid.BancoDeDadosinnerJoinDataSet1.CarrosRow;

            switch (e.ColumnIndex)
            {
                case 0:
                    {
                        this.carrosTableAdapter1.DeleteQuery(carSelect.Id);
                    } break;
                case 1:
                    {
                        frmEdicaCarros editCarro = new frmEdicaCarros();
                        editCarro.CarrosRow = carSelect;
                        editCarro.ShowDialog();
                        this.carrosTableAdapter1.UpdateQuery(editCarro.CarrosRow.Modelo,
                                                            editCarro.CarrosRow.Ano.ToString(),
                                                            editCarro.CarrosRow.Marca,
                                                            editCarro.CarrosRow.Ativo,
                                                            editCarro.CarrosRow.UsuAlt,
                                                            DateTime.Now,
                                                            editCarro.CarrosRow.Id
                                                            );
                    }break;
            }
            
            this.carrosTableAdapter1.CustomQuery(bancoDeDadosinnerJoinDataSet1.Carros);
        }

        private void BtLixeira_Click(object sender, EventArgs e)
        {
            frmLixeiraCarros lixeira = new frmLixeiraCarros();
            lixeira.ShowDialog();

            this.carrosTableAdapter1.CustomQuery(bancoDeDadosinnerJoinDataSet1.Carros);
        }

        private void BtnAdcionar_Click(object sender, EventArgs e)
        {
            frmAdicionarCarro formAdd = new frmAdicionarCarro();        
            formAdd.ShowDialog();

            this.carrosTableAdapter1.Insert(
                formAdd.carrosRow.Modelo,
                formAdd.carrosRow.Ano,
                formAdd.carrosRow.Marca,
                true,
                1,
                1,
                DateTime.Now,
                DateTime.Now);
            //Atualiza a tabela
            this.carrosTableAdapter1.CustomQuery(bancoDeDadosinnerJoinDataSet1.Carros);
        }
    }
}
