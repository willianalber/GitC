using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FormularioCarros.Classes;

namespace FormularioCarros
{
    public partial class frmTelaInicial : Form
    {
        public List<Carro> listaDeCarros = new List<Carro>();
        public frmTelaInicial()
        {
            InitializeComponent();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listaDeCarros;
            
        }
        
        private void CadastrarVeiculosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadatroVeiculo formCadVeiculos = new frmCadatroVeiculo();
            formCadVeiculos.ShowDialog();
            listaDeCarros.Add(formCadVeiculos.novoCarro);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listaDeCarros;
        }

        private void DataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < -1)
            {
                //
                var collEdit = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
                var datCollSelect = collEdit.OwningColumn.DataPropertyName;

                List<Carro> novaLista = new List<Carro>();


                foreach (Carro item in listaDeCarros)
                {
                    novaLista.Add
                        (
                            new Carro()
                            {
                                Ano = item.Ano,
                                Modelo = item.Modelo,
                                Placa = item.Placa

                            }
                        ) ;
                }

                switch (datCollSelect)
                {
                    case "Modelo":
                        {
                            this.listaDeCarros
                        } break;
                }

            }
        }
    }
}
