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
    public partial class frmCadatroVeiculo : Form
    {
        public frmCadatroVeiculo()
        {
            InitializeComponent();
            int ano = (DateTime.Now.Year);
            for (int i = 0; i <= 200; i++)
            {
                cbAno.Items.Add(ano--);
            }
        }

        public Carro novoCarro = new Carro();

        private void Button1_Click(object sender, EventArgs e)
        {
            novoCarro.Modelo = txtModelo.Text;
            novoCarro.Ano = int.Parse(cbAno.Text);
            novoCarro.Placa = maskedPlaca.Text;
            this.Close();
        }
    }
}
