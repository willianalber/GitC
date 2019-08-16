using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculadoraLEN;

namespace TesteClasseHbsis
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 teste = new Class1();            

            Console.WriteLine($"Soma  5 + 5 = {teste.Soma_Lendaria(5,5)}");
            Console.WriteLine($"Subtração  5 - 2 = {teste.Menos_Lendario(5, 2)}");
            Console.WriteLine($"Multiplicação  5 X 5 = {teste.Multiplicacao_Lendaria(5, 5)}");
            Console.WriteLine($"Divisão  4 / 2 = {teste.Divisao_Lendaria(4, 2)}");
            Console.WriteLine($"Area do Retangulo: base:5 altura:5 = {teste.Area_Retangulo(5, 5)}");
            Console.WriteLine($"Area do Triangulo: base:5 altura:5 = {teste.Area_Triangulo_Equilatero(5, 5)}");
            Console.WriteLine($"Raio do circulo com area:  = {teste.Raio_Circulo_Lendario(78.5)}");

            Console.ReadKey();
        }
    }
}
