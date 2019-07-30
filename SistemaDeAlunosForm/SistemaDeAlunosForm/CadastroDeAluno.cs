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
    public partial class frmCadastroDeAluno : Form
    {
        public frmCadastroDeAluno()
        {
            InitializeComponent();
            for (int i = 0; i < 150; i++)
            {
                cbIdade.Items.Add(i);
            }
        }

        public Aluno novoAluno = new Aluno();


        private void BtCadastrar_Click(object sender, EventArgs e)
        {
            novoAluno.Nome = txtNome.Text;
            novoAluno.Idade = int.Parse(cbIdade.Text);
           // MessageBox.Show("Aluno cadastrado com sucesso!");
            this.Close();
        }


    }
}
