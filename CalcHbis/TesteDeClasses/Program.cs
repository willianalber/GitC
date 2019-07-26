using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalcHbis;

namespace TesteDeClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new MathHbsis().RetornaMultiplicacao(2,5));
            Console.WriteLine(new MathHbsis().RetornaDivisao(10,5));
            Console.WriteLine(new MathHbsis().RetornaAreaTrianguloEquilatero(5,5));
            Console.WriteLine(new MathHbsis().RetornaAreaRetangulo(5,5));
            Console.WriteLine(new MathHbsis().RetornaRaioDeUmCirculo(78.5));

            Console.ReadKey();
        }
    }
}
