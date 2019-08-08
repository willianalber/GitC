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
    /// Interaction logic for ucLogin.xaml
    /// </summary>
    public partial class ucLogin : UserControl
    {
        public ucLogin()
        {
            InitializeComponent();

        }

        public event EventHandler LoginCorreto;

        public void validaAcesso(string user, string password)
        {
            if (user == "admin" && password == "admin")
            {
                this.Visibility = Visibility.Hidden;
                
                LoginCorreto(null,new EventArgs());
            }
            else
            {
                MessageBox.Show("Senha ou usuario incorreto! verifique");
            }
        }

        private void BtEntrar_Click(object sender, RoutedEventArgs e)
        {
            validaAcesso(textUsuario.Text,passwdSenha.Password);
        }
    }
}
