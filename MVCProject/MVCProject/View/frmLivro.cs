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
    public partial class frmLivro : Form
    {
        public frmLivro()
        {
            InitializeComponent();
        }

        private void Livro_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemaBibliotecaDBDataSet.Livro' table. You can move, or remove it, as needed.
            livroTableAdapter.LivrosAtivos(sistemaBibliotecaDBDataSet.Livro);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            frmAdicionarLivro formAddLivro = new frmAdicionarLivro();
            formAddLivro.ShowDialog();
            if (formAddLivro.novoLivro != null)
            {
                this.livroTableAdapter.Insert(formAddLivro.novoLivro.Registro,
                                              formAddLivro.novoLivro.Titulo,
                                              formAddLivro.novoLivro.Tipo,
                                              formAddLivro.novoLivro.Descricao,
                                              formAddLivro.novoLivro.Isbn,
                                              formAddLivro.novoLivro.Genero,
                                              formAddLivro.novoLivro.Editora,
                                              formAddLivro.novoLivro.Sinopse,
                                              formAddLivro.novoLivro.Observacoes,
                                              formAddLivro.novoLivro.Ativo,
                                              formAddLivro.novoLivro.UsuInc,
                                              formAddLivro.novoLivro.UsuAlt,
                                              formAddLivro.novoLivro.DataInc,
                                              formAddLivro.novoLivro.DataALt);
            }
            livroTableAdapter.LivrosAtivos(sistemaBibliotecaDBDataSet.Livro);
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var livroSelect = ((DataRowView)this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
                           as MVCProject.SistemaBibliotecaDBDataSet.LivroRow;

            switch (e.ColumnIndex)
            {
                case 0:
                    {
                        this.livroTableAdapter.DeleteQuery(livroSelect.Id);
                    }break;
                default:
                    break;
            }

            livroTableAdapter.LivrosAtivos(sistemaBibliotecaDBDataSet.Livro);
        }
    }
}
