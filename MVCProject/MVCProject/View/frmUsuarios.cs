using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MVCProject.View.Adicionar;

namespace MVCProject.View
{
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemaBibliotecaDBDataSet.Usuario' table. You can move, or remove it, as needed.
            this.usuarioTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Usuario);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            frmAdicionarUsuario formAdUsuario = new frmAdicionarUsuario();
            formAdUsuario.ShowDialog();
            if (formAdUsuario.novoUsuario != null)
            {
                this.usuarioTableAdapter.Insert(formAdUsuario.novoUsuario.Nome
                    , formAdUsuario.novoUsuario.Login
                    , formAdUsuario.novoUsuario.Senha
                    , formAdUsuario.novoUsuario.Email
                    , true
                    , formAdUsuario.novoUsuario.UsuInc
                    , formAdUsuario.novoUsuario.UsuAlt
                    , formAdUsuario.novoUsuario.DataInc
                    , formAdUsuario.novoUsuario.DataALt);
            }

            this.usuarioTableAdapter.Fill(sistemaBibliotecaDBDataSet.Usuario);
        }
    }
}
