using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cantina2.Classes;

namespace Cantina2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Lanche> cardapio = new List<Lanche>();
            for (int i = 0; i < 5; i++)
            {                              
                cardapio.Add( new Lanche() { Nome = RetornaValores("Nome"),
                                             Quantidade = int.Parse(RetornaValores("Quantidade")),
                                             Valor =int.Parse(RetornaValores("Valor"))});
            }
            Console.Clear();
            foreach (Lanche item in cardapio)
            {
                Console.WriteLine($"Nome: {item.Nome} Quantidade: {item.Quantidade} Valor: {item.Valor}");
            }
            Console.ReadKey();

        }

        public static string RetornaValores(string nome)
        {
            Console.WriteLine($"Informe o valor para o campo {nome}");
            return Console.ReadLine();
        }

    }
}
