using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBAViewGrayAcsess
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bancoDeDadosinnerJoinDataSet.Marcas' table. You can move, or remove it, as needed.
            this.marcasTableAdapter.Fill(this.bancoDeDadosinnerJoinDataSet.Marcas);
            // TODO: This line of code loads data into the 'bancoDeDadosinnerJoinDataSet.Carros' table. You can move, or remove it, as needed.
            this.carrosTableAdapter.Fill(this.bancoDeDadosinnerJoinDataSet.Carros);

        }
    }
}
