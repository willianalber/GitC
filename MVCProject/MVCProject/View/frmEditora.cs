using MVCProject.View.Adicionar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVCProject.View
{
    public partial class frmEditora : Form
    {
        public frmEditora()
        {
            InitializeComponent();
        }

        private void FrmEditora_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemaBibliotecaDBDataSet.Editora' table. You can move, or remove it, as needed.
            this.editoraTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Editora);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            frmAdicionarAutor formEditora = new frmAdicionarAutor();
            formEditora.Text = "Adicionar uma editora";
            formEditora.ShowDialog();
            if (formEditora.novoAutor != null)
            {
                this.editoraTableAdapter.Insert(formEditora.novoAutor.Nome, formEditora.novoAutor.Descricao);
            }
            this.editoraTableAdapter.Fill(sistemaBibliotecaDBDataSet.Editora);
        }
    }
}
