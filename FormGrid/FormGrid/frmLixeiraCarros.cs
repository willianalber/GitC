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
    public partial class frmLixeiraCarros : Form
    {
        public frmLixeiraCarros()
        {
            InitializeComponent();
        }

        private void FrmLixeiraCarros_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bancoDeDadosinnerJoinDataSet1.Carros' table. You can move, or remove it, as needed.
            //this.carrosTableAdapter.Inativos(this.bancoDeDadosinnerJoinDataSet1.Carros);

            this.carrosTableAdapter.Inativos(this.bancoDeDadosinnerJoinDataSet1.Carros);

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var carLixeiraSelect = ((System.Data.DataRowView)
                           this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
                           as FormGrid.BancoDeDadosinnerJoinDataSet1.CarrosRow;

            if (carLixeiraSelect != null)
            {
                switch (e.ColumnIndex)
                {
                    case 0:
                        {
                            this.carrosTableAdapter.RecuperarDados(carLixeiraSelect.Id);
                        }
                        break;
                }
            }

            

            this.carrosTableAdapter.Inativos(this.bancoDeDadosinnerJoinDataSet1.Carros);
        }
    }
}
