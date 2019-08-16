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
    public partial class frmAdicionarLivro : Form
    {
        public frmAdicionarLivro()
        {
            InitializeComponent();
        }

        public Livro novoLivro;

        private void FrmAdicionarLivro_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemaBibliotecaDBDataSet.Editora' table. You can move, or remove it, as needed.
            this.editoraTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Editora);
            // TODO: This line of code loads data into the 'sistemaBibliotecaDBDataSet.Genero' table. You can move, or remove it, as needed.
            this.generoTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Genero);
            // TODO: This line of code loads data into the 'sistemaBibliotecaDBDataSet.Editora' table. You can move, or remove it, as needed.
            this.editoraTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Editora);
            // TODO: This line of code loads data into the 'sistemaBibliotecaDBDataSet.Genero' table. You can move, or remove it, as needed.
            this.generoTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Genero);

        }

        
        private void Button2_Click(object sender, EventArgs e)
        {
            novoLivro = new Livro();
            this.novoLivro.Registro = int.Parse(txtRegistro.Text);
            this.novoLivro.Titulo = txtTitulo.Text;
            this.novoLivro.Tipo = txtTipo.Text;
            this.novoLivro.Descricao = txtDescricao.Text;
            this.novoLivro.Isbn = txtISBN.Text;
            this.novoLivro.Genero = (int)cbGenero.SelectedValue;
            this.novoLivro.Editora = (int)cbEditora.SelectedValue;
            this.novoLivro.Sinopse = txtSinopse.Text;
            this.novoLivro.Observacoes = txtObservacoes.Text;
            this.novoLivro.Ativo = true;
            this.novoLivro.DataALt = DateTime.Now;
            this.novoLivro.DataInc = DateTime.Now;
            this.novoLivro.UsuAlt = 2;
            this.novoLivro.UsuInc = 2;

            this.Close();
        }

        private void TxtRegistro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsLetter(e.KeyChar)) || (Char.IsWhiteSpace(e.KeyChar)))
                e.Handled = true;
        }
    }
}
