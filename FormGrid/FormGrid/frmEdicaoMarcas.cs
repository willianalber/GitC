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
    public partial class frmEdicaoMarcas : Form
    {
        public frmEdicaoMarcas()
        {
            InitializeComponent();
        }

        public FormGrid.BancoDeDadosinnerJoinDataSet1.MarcasRow linhaDaTabelaMarcas;

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        private void BtSalvar_Click(object sender, EventArgs e)
        {
            linhaDaTabelaMarcas.Nome = txtNomeMarca.Text;
            linhaDaTabelaMarcas.DatAlt = DateTime.Now;
            this.Close();
        }

        private void FrmEdicaoMarcas_Load(object sender, EventArgs e)
        {
            txtNomeMarca.Text = linhaDaTabelaMarcas.Nome;
        }
    }
}
