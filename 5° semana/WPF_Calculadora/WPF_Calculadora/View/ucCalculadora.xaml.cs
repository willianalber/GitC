using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_Calculadora.View
{
    /// <summary>
    /// Interaction logic for ucCalculadora.xaml
    /// </summary>
    public partial class ucCalculadora : UserControl
    {
        public ucCalculadora()
        {
            InitializeComponent();
        }

        public event EventHandler EventoRetornaCaption;

        public string retornaCapition(Button botao)
        {
            return botao.Content.ToString();
        }
        


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            CalculadoraLEN.Class1 calcular = new CalculadoraLEN.Class1();

            if (rbSomar.IsChecked == true)
            {
                lbResultado.Content = calcular.Soma_Lendaria(int.Parse(txtN1.Text), int.Parse(txtN2.Text)).ToString();
            }else
                if (rbSubtrair.IsChecked == true)
            {
                lbResultado.Content = calcular.Menos_Lendario(int.Parse(txtN1.Text), int.Parse(txtN2.Text)).ToString();
            }
            else
                if (rbDividir.IsChecked == true)
            {
                lbResultado.Content = calcular.Divisao_Lendaria(int.Parse(txtN1.Text), int.Parse(txtN2.Text)).ToString();
            }
            else
                if (rbMultiplicar.IsChecked == true)
            {
                lbResultado.Content = calcular.Multiplicacao_Lendaria(int.Parse(txtN1.Text), int.Parse(txtN2.Text)).ToString();
            }

        }

        private void Bt1_Click(object sender, RoutedEventArgs e)
        {
            te
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
