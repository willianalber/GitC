using MVCProject.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MVCProject.View;

namespace MVCProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int Id;

        private void Button1_Click(object sender, EventArgs e)
        {
            

            var result = this.usuarioTableAdapter1.LoginQuery(txtUsuario.Text, txtSenha.Text);

            if (result != null)
            {
                Session.user = new Usuario
                {
                    Id = (int)result
                };

                frmPrincipal formPrincipal = new frmPrincipal();
                formPrincipal.ShowDialog();
            }
            else
            {
                MessageBox.Show("Senha ou usuario incorreto! Verifique.");
                //throw new Exception("Fuuuuuuuuuuuuuu!");
            }
        }
    }
}
