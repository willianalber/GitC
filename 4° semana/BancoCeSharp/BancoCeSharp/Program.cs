using BancoCeSharp.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoCeSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta accountUser = new Conta();

            Console.WriteLine("Informe um valor para saque: ");
            double.TryParse(Console.ReadLine(), out double valorSacar)
           

            accountUser.Sacar(2000);

            Console.ReadKey();
        }
    }
}
