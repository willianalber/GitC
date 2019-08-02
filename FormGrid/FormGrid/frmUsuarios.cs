using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormGrid
{
    public partial class Usuarios : Form
    {
        public Usuarios()
        {
            InitializeComponent();
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bancoDeDadosinnerJoinDataSet1.Usuarios' table. You can move, or remove it, as needed.
            this.usuariosTableAdapter.CustomQuery(this.bancoDeDadosinnerJoinDataSet1.Usuarios);

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var usuariosSelect = ((System.Data.DataRowView)
                           this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
                           as FormGrid.BancoDeDadosinnerJoinDataSet1.UsuariosRow;

            

            switch (e.ColumnIndex)
            {
                case 0:
                    {
                        this.usuariosTableAdapter.DeleteQuery(usuariosSelect.Id);
                    }break;
                case 1:
                    {
                        frmAlteracaoUsuario editUsuario = new frmAlteracaoUsuario();
                        editUsuario.linhaDaabelaUsuario = usuariosSelect;
                        editUsuario.ShowDialog();
                        this.usuariosTableAdapter.Update(editUsuario.linhaDaabelaUsuario);
                    }break;
            }
            this.usuariosTableAdapter.CustomQuery(bancoDeDadosinnerJoinDataSet1.Usuarios);
        }

        private void BtnAdcionar_Click(object sender, EventArgs e)
        {
            frmAlteracaoUsuario formUsuario = new frmAlteracaoUsuario();
            formUsuario.Text = "Cadastro de usuarios";
            formUsuario.ShowDialog();
            if (formUsuario.objUsuario.Nome != null)            
                this.usuariosTableAdapter.Insert(formUsuario.objUsuario.Nome, true, 1, 1, DateTime.Now, DateTime.Now);
            this.usuariosTableAdapter.CustomQuery(bancoDeDadosinnerJoinDataSet1.Usuarios);
        }
    }
}
