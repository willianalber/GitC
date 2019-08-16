using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaiorDeIdade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nome:");
            Console.ReadLine();
            Console.WriteLine("Digite a idade do usuario: ");
           if (int.Parse(Console.ReadLine()) >= 18)
            {
                Console.WriteLine("Está autorizado a consumir bebidas alcoólicas!");
            }
            else
            {
                Console.WriteLine("Não está autorizado a consumir bebidas alcoólicas!");
            }
            Console.ReadKey();
        }
    }
}
