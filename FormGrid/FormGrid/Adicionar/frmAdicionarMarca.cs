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
    public partial class frmAdicionarMarca : Form
    {
        public frmAdicionarMarca()
        {
            InitializeComponent();
        }

        public ClasseMarca marca = new ClasseMarca();

        private void BtSalvar_Click(object sender, EventArgs e)
        {
            marca.Nome = txtNomeMarca.Text;

            this.Close();
        }
    }
}
