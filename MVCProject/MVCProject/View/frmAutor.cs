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
    public partial class frmAutor : Form
    {
        public frmAutor()
        {
            InitializeComponent();
        }
        static int id = 0;
        private void FrmAutor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemaBibliotecaDBDataSet.Autor' table. You can move, or remove it, as needed.
            this.autorTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Autor);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            frmAdicionarAutor formAdicionarAutor = new frmAdicionarAutor();
            formAdicionarAutor.ShowDialog();
            if (formAdicionarAutor.novoAutor != null)
            {
                this.autorTableAdapter.Insert(id++,formAdicionarAutor.novoAutor.Nome, formAdicionarAutor.novoAutor.Descricao);
            }
            this.autorTableAdapter.Fill(sistemaBibliotecaDBDataSet.Autor);
        }
    }
}
