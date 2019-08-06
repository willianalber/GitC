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

        public MVCProject.SistemaBibliotecaDBDataSet.UsuarioRow linhaDaTabelaUsuario;
        private void BtOk_Click(object sender, EventArgs e)
        {
           

            novoUsuario = new Usuario()
            {
                Nome = txtNome.Text,
                Login = txtUsuario.Text,
                Senha = txtSenha.Text,
                Email = txtEmail.Text,
                UsuInc = 1007,
                UsuAlt = 1007
            };

            this.Close();
        }

        private void FrmAdicionarUsuario_Load(object sender, EventArgs e)
        {
            if (linhaDaTabelaUsuario != null)
            {
                txtNome.Text = linhaDaTabelaUsuario.Nome;
                txtEmail.Text = linhaDaTabelaUsuario.Email;
                txtSenha.Text = linhaDaTabelaUsuario.Senha;
                txtUsuario.Text = linhaDaTabelaUsuario.Login;
            }
        }
    }
}
