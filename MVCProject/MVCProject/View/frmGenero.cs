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
    public partial class frmGenero : Form
    {
        public frmGenero()
        {
            InitializeComponent();
        }

        private void FrmGenero_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemaBibliotecaDBDataSet.Genero' table. You can move, or remove it, as needed.
            this.generoTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Genero);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            frmAdicionarAutor formGenero = new frmAdicionarAutor();
            formGenero.Text = "Adicionar um Gênero";
            formGenero.ShowDialog();
            if (formGenero.novoAutor != null)
            {
                this.generoTableAdapter.Insert(formGenero.novoAutor.Nome, formGenero.novoAutor.Descricao);
            }
            this.generoTableAdapter.Fill(sistemaBibliotecaDBDataSet.Genero);
            
        }
    }
}
