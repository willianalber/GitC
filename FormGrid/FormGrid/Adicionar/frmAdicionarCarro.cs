using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FormGrid.Model;

namespace FormGrid.Adicionar
{
    public partial class frmAdicionarCarro : Form
    {
        public frmAdicionarCarro()
        {
            InitializeComponent();
        }

        public Carro carrosRow;

        private void FrmAdicionarCarro_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bancoDeDadosinnerJoinDataSet1.Marcas' table. You can move, or remove it, as needed.
            this.marcasTableAdapter.Fill(this.bancoDeDadosinnerJoinDataSet1.Marcas);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            carrosRow = new Carro()
            {
                Modelo = txtModelo.Text,
                Ano = dtAno.Value,
                Marca = (int)cbMarca.SelectedValue
            };

           

            this.Close();
        }
    }
}
