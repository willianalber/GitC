using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MVCProject.Model;

namespace MVCProject.View.Adicionar
{
    public partial class frmAdicionarUsuario : Form
    {
        public frmAdicionarUsuario()
        {
            InitializeComponent();
        }

        public Usuario novoUsuario;
        private void BtOk_Click(object sender, EventArgs e)
        {
            novoUsuario = new Usuario()
            {
                Nome = txtNome.Text,
                Login = txtUsuario.Text,
                Senha = txtSenha.Text,
                Email = txtEmail.Text,
                UsuInc = 2,
                UsuAlt = 2
            };

            this.Close();
        }
    }
}
