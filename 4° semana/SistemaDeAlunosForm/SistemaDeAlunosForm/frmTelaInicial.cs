using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaDeAlunosForm.Classes;

namespace SistemaDeAlunosForm
{
    public partial class frmTelaInicial : Form
    {

        public List<Aluno> ListaDeAlunos = new List<Aluno>();

        public frmTelaInicial()
        {
            InitializeComponent();

            
        }
            

               

        private void CadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroDeAluno telaCadastro = new frmCadastroDeAluno();
            telaCadastro.ShowDialog();
            ListaDeAlunos.Add(telaCadastro.novoAluno);
            dataGridView1.DataSource = null;
            //dataGridView1.Refresh();
            dataGridView1.DataSource = ListaDeAlunos;
           // dataGridView1.Refresh();

        }

        
    }
}
