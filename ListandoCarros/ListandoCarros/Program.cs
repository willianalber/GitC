using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListandoCarros.Classes;

namespace ListandoCarros
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Carro> listaDeCarros = new List<Carro>();

            int op = RetornaOpMenu();
            while (op != 3)
            {
                if (op == 1)
                {
                    Console.Clear();
                    ListarCarros(listaDeCarros);
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (op == 2)
                {
                    Console.Clear();
                    listaDeCarros = Carro.AddCarros(listaDeCarros);
                    Console.Clear();
                }

                op = RetornaOpMenu();
            }
        }

        

        private static void ListarCarros(List<Carro> listaDeCarros)
        {
            foreach (Carro item in listaDeCarros)
            {
                Console.WriteLine($"Modelo: {item.Modelo} Ano: {item.Ano} Placa:" +
                                  $" {item.Placa} Cavalos: {item.Cv}");
            }
        }

        public static int RetornaOpMenu()
        {
            Console.WriteLine("Digite uma das opções abaixo: ");
            Console.WriteLine(" 1 - Listar: ");
            Console.WriteLine(" 2 - Adicioar: ");
            Console.WriteLine(" 3 - Sair: ");
            int.TryParse(Console.ReadLine(), out int op);
            return op;
        }
    }
}
