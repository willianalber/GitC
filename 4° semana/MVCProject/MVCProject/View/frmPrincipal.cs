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

namespace MVCProject.View
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void UsuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuarios formUsuarios = new frmUsuarios();
            formUsuarios.ShowDialog();
        }

        private void AutoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAutor formAutor = new frmAutor();
            formAutor.ShowDialog();
        }

        private void GênerosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGenero formGenero = new frmGenero();
            formGenero.ShowDialog();
        }

        private void LivrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLivro formLivro = new frmLivro();
            formLivro.ShowDialog();
        }

        private void LocaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLocacao formLocacao = new frmLocacao();
            formLocacao.ShowDialog();
        }

        private void EditorasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEditora formEditora = new frmEditora();
            formEditora.ShowDialog();
        }
    }
}
