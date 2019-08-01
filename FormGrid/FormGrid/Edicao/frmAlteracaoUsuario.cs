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
    public partial class frmAlteracaoUsuario : Form
    {
        public frmAlteracaoUsuario()
        {
            InitializeComponent();
        }

        public FormGrid.BancoDeDadosinnerJoinDataSet1.UsuariosRow linhaDaabelaUsuario;

        private void BtSalvar_Click(object sender, EventArgs e)
        {
            linhaDaabelaUsuario.Usuario = txtNome.Text;

            this.Close();
        }

        private void FrmAlteracaoUsuario_Load(object sender, EventArgs e)
        {
            txtNome.Text = linhaDaabelaUsuario.Usuario;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}
