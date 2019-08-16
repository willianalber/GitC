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
    public partial class frmLocacao : Form
    {
        public frmLocacao()
        {
            InitializeComponent();
        }

        private void FrmLocacao_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemaBibliotecaDBDataSet.Locacao' table. You can move, or remove it, as needed.
            this.locacaoTableAdapter.LocacaoAtiva(this.sistemaBibliotecaDBDataSet.Locacao);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            frmAdicionarLocacao formAddLocacao = new frmAdicionarLocacao();
            formAddLocacao.ShowDialog();
            if (formAddLocacao.novaLocacao != null)
            {
                locacaoTableAdapter.Insert(formAddLocacao.novaLocacao.Livro,
                                           formAddLocacao.novaLocacao.Usuario,
                                            formAddLocacao.novaLocacao.Tipo,
                                            formAddLocacao.novaLocacao.Devolucao,
                                            formAddLocacao.novaLocacao.Ativo,
                                            formAddLocacao.novaLocacao.UsuInc,
                                            formAddLocacao.novaLocacao.UsuAlt,
                                            formAddLocacao.novaLocacao.DataInc,
                                            formAddLocacao.novaLocacao.DataALt);
            }

            this.locacaoTableAdapter.LocacaoAtiva(this.sistemaBibliotecaDBDataSet.Locacao);

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var locacaoSelect = ((DataRowView)this.dtLocacao.Rows[e.RowIndex].DataBoundItem).Row
                           as MVCProject.SistemaBibliotecaDBDataSet.LocacaoRow;


            switch (e.ColumnIndex)
            {
                case 0:
                    {
                        this.locacaoTableAdapter.DeleteQuery(locacaoSelect.Id);
                    }
                    break;
                default:
                    break;
            }

            locacaoTableAdapter.LocacaoAtiva(sistemaBibliotecaDBDataSet.Locacao);
        }
    }
}
