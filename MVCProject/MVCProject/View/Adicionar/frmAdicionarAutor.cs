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
    public partial class frmAdicionarAutor : Form
    {
        public frmAdicionarAutor()
        {
            InitializeComponent();
        }

        public Autor novoAutor;
        private void BtOk_Click(object sender, EventArgs e)
        {
            novoAutor = new Autor();
            this.novoAutor.Nome = txtNome.Text;
            this.novoAutor.Descricao = txtDescricao.Text;          

        }
    }
}
