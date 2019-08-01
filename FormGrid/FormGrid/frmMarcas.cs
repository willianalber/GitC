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
    public partial class frmMarcas : Form
    {
        public frmMarcas()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bancoDeDadosinnerJoinDataSet1.Marcas' table. You can move, or remove it, as needed.
            this.marcasTableAdapter.CustomQuery(this.bancoDeDadosinnerJoinDataSet1.Marcas);            

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var marcasSelect = ((DataRowView)this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
                           as FormGrid.BancoDeDadosinnerJoinDataSet1.MarcasRow;

            switch (e.ColumnIndex)
            {
                case 0:
                    {
                        this.marcasTableAdapter.DeleteQuery(marcasSelect.Id);
                    } break;
                case 1:
                    {
                        frmEdicaoMarcas edtMarcas = new frmEdicaoMarcas();
                        edtMarcas.linhaDaTabelaMarcas = marcasSelect;
                        edtMarcas.ShowDialog();
                        this.marcasTableAdapter.Update(edtMarcas.linhaDaTabelaMarcas);                


                    }break;
            }
            
            this.marcasTableAdapter.CustomQuery(bancoDeDadosinnerJoinDataSet1.Marcas);
        }

        
    }
}
