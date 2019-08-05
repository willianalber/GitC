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
    public partial class frmAdicionarLocacao : Form
    {
        public frmAdicionarLocacao()
        {
            InitializeComponent();
        }

        public Locacao novaLocacao;

        private void FrmAdicionarLocacao_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemaBibliotecaDBDataSet.Livro' table. You can move, or remove it, as needed.
            this.livroTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Livro);

        }

        private void FillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.livroTableAdapter.FillBy(this.sistemaBibliotecaDBDataSet.Livro);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            novaLocacao = new Locacao();
            novaLocacao.Livro = (int)comboBox1.SelectedValue;
            novaLocacao.Usuario = Session.user.Id;
            novaLocacao.Tipo = comboBox2.SelectedIndex;
            novaLocacao.Devolucao = dtDevolucao.Value;
            novaLocacao.Ativo = true;
            novaLocacao.UsuInc = Session.user.Id;
            novaLocacao.UsuAlt = Session.user.Id;

            this.Close();
        }
    }
}
