using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TabelaDeVizualizacaoDeValores.Model;

namespace TabelaDeVizualizacaoDeValores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Contrac> listContracs = new List<Contrac>();

        private void BtnAdcionar_Click(object sender, EventArgs e)
        {
            listContracs.Add(new Contrac()
            {
                Id = listContracs.Count,
                Value = new Random().Next(100),
                DatInc = DateTime.Now
            }) ;

            var newList = new List<Contrac>();
            foreach (Contrac item in listContracs)
            {
                newList.Add(new Contrac()

                {
                    Id = item.Id,
                    Value = item.Value,
                    DatInc = item.DatInc
                });
                    
            }

            dataGridView2.DataSource = null;
            dataGridView2.DataSource = newList;
        }

        private void DataGridView2_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                var collumId = dataGridView2.Rows[e.RowIndex].Cells[0];
                var collumValue = dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex];

                switch (e.ColumnIndex)
                {
                    case 0: {
                            MessageBox.Show("Não é possivel ajustar este valor!");
                        } break;
                    case 1: {
                            if (MessageBox.Show("Deseja realmente ajustar este valor ?",
                                                                                  "Edição",
                                                                                  MessageBoxButtons.YesNo,
                                                                                  MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                listContracs.FirstOrDefault(x =>
                                x.Id == (int)collumId.Value).Value = (int)collumValue.Value;
                            }
                        } break;
                    case 2:
                        {
                            if (MessageBox.Show("Deseja realmente ajustar este valor ?"
                                ,"Edição"
                                , MessageBoxButtons.YesNo
                                , MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                var dataInformada = DateTime.Parse(collumValue.Value.ToString());

                                if (dataInformada <= DateTime.Now)
                                {
                                    listContracs.FirstOrDefault(x =>
                                    x.Id == (int)collumId.Value).Value = (int)collumValue.Value;
                                }
                                else
                                {
                                    MessageBox.Show("Não é possivel ajustar este valor!");
                                }
                                
                            }


                        } break;
                }
            }
        }
    }
}
