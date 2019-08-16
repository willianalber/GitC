using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormGrid
{
    public partial class frmVendas : Form
    {
        public frmVendas()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bancoDeDadosinnerJoinDataSet1.Vendas' table. You can move, or remove it, as needed.
            this.vendasTableAdapter.CustomQuery(this.bancoDeDadosinnerJoinDataSet1.Vendas);

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var vendasSelect = ((DataRowView)
                           this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
                           as FormGrid.BancoDeDadosinnerJoinDataSet1.VendasRow;

            switch (e.ColumnIndex)
            {
                case 0:
                    {
                        this.vendasTableAdapter.DeleteQuery(vendasSelect.Id);
                    } break;
                case 1:
                    {
                        frmEdicaoVendas vendasEdicao = new frmEdicaoVendas();
                        vendasEdicao.linhaDeVendas = vendasSelect;
                        vendasEdicao.ShowDialog();
                        this.vendasTableAdapter.Update(vendasEdicao.linhaDeVendas);
                    }break;


            }
            this.vendasTableAdapter.CustomQuery(bancoDeDadosinnerJoinDataSet1.Vendas);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            frmEdicaoVendas formAddVnda = new frmEdicaoVendas();
            formAddVnda.Text = "Adicionar uma venda";
            formAddVnda.ShowDialog();
            if (formAddVnda.objVendas != null)
            {
                this.vendasTableAdapter.Insert(formAddVnda.objVendas.Carro,
                                                formAddVnda.objVendas.Quantidade,
                                                formAddVnda.objVendas.Valor, 
                                                true,
                                                1,
                                                1,
                                                DateTime.Now,
                                                DateTime.Now);
            }
            this.vendasTableAdapter.CustomQuery(bancoDeDadosinnerJoinDataSet1.Vendas);
        }
    }
}
