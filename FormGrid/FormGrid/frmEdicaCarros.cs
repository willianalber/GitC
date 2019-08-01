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
    public partial class frmEdicaCarros : Form
    {
        public frmEdicaCarros()
        {
            InitializeComponent();
        }

        public FormGrid.BancoDeDadosinnerJoinDataSet1.CarrosRow CarrosRow;

        private void FrmEdicaCarros_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bancoDeDadosinnerJoinDataSet1.Marcas' table. You can move, or remove it, as needed.
            this.marcasTableAdapter.Fill(this.bancoDeDadosinnerJoinDataSet1.Marcas);

            txtModelo.Text = CarrosRow.Modelo;
            dtAno.Text = CarrosRow.Ano.ToString("dd/MM/yyyy");
            cbMarca.SelectedValue = CarrosRow.Marca;  


        }

        

        private void Button1_Click(object sender, EventArgs e)
        {
            CarrosRow.Modelo = txtModelo.Text;
            CarrosRow.Ano = dtAno.Value;
            CarrosRow.Marca = (int)cbMarca.SelectedValue;



            this.Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
