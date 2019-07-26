using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoCalculadora;

namespace Projeto_de_calcular
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Digite o 1º numero: ");
            int.TryParse(Console.ReadLine(), out int n1);
            Console.WriteLine("Digite o 2º numero: ");
            int.TryParse(Console.ReadLine(), out int n2);
            var objeto = new Calculadora();

            Console.WriteLine("Soma: " + objeto.somar(n1, n2));
            Console.WriteLine("Subtração: " + objeto.subtrair(n1, n2));
            Console.WriteLine("Multiplicação: " + objeto.multiplicar(n1, n2));
            Console.WriteLine("Divisão: " + objeto.dividir(n1, n2));

            Console.ReadKey();

        }
    }
}
