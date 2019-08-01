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
    public partial class frmEdicaoVendas : Form
    {
        public frmEdicaoVendas()
        {
            InitializeComponent();
        }

        public FormGrid.BancoDeDadosinnerJoinDataSet1.VendasRow linhaDeVendas;

        private void FrmEdicaoVendas_Load(object sender, EventArgs e)
        {
            
            // TODO: This line of code loads data into the 'bancoDeDadosinnerJoinDataSet1.Carros' table. You can move, or remove it, as needed.
            this.carrosTableAdapter.Fill(this.bancoDeDadosinnerJoinDataSet1.Carros);

            cbCarro.SelectedValue = linhaDeVendas.Carro;
            txtQuantidade.Text = linhaDeVendas.Quantidade.ToString();
            txtValor.Text = linhaDeVendas.Valor.ToString();

        }

        private void FillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.carrosTableAdapter.FillBy(this.bancoDeDadosinnerJoinDataSet1.Carros);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void BtSalvar_Click(object sender, EventArgs e)
        {
            linhaDeVendas.Carro = (int)cbCarro.SelectedValue;
            linhaDeVendas.Quantidade = int.Parse(txtQuantidade.Text);
            linhaDeVendas.Valor = decimal.Parse(txtValor.Text);
            this.Close();
        }
    }
}
