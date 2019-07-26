using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MostrarJoinhaClass;

namespace UsandoBibliotecaJoin
{
    class Program
    {
        static void Main(string[] args)

        {
            new AquiMostraJoinha().MetodoInicialDoJoinha();

            new AquiMostraJoinha().MetodoDoisPontoZero(true);

            new AquiMostraJoinha().MetodoDoisPontoZero(false);

            var outroCaraParaRealizarOTeste = new AquiMostraJoinha();

            var teste = outroCaraParaRealizarOTeste.GetType();

            Console.WriteLine(teste);

            Console.WriteLine(new AquiMostraJoinha().TesteUmOperadorLegal());

            Console.ReadKey();
        }
    }
}
