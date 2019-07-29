using SistemaCantinaGG1.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCantinaGG1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno("Willian", 18);
            Cantina cardapio = new Cantina();

            int op = mostrarMenu(cardapio);
            while (op != cardapio.cardapio.Count())
            {
                if (op <= cardapio.cardapio.Count())
                {
                    if (aluno.Sacar(cardapio.cardapio[op].Valor))
                    {
                        Console.Clear();
                        Console.WriteLine($"Lanche a ser comprado : {cardapio.cardapio[op].Descricao} " +
                                                               $"R$ {cardapio.cardapio[op].Valor}\n" +
                                                               $"Saldo: {aluno.Saldo}");

                    }
                    else
                    {

                        Console.WriteLine("Saldo insuficiente!");
                    }
                }
                else
                {
                    Console.WriteLine("Opção invalida!");
                }
                op = mostrarMenu(cardapio);
            }   
        }

        public static int mostrarMenu(Cantina cardapio)
        {
            
            Console.WriteLine("Informe um dos lanches abaixo para comprar:");
            int cont = 0;
            foreach (var item in cardapio.cardapio)
            {
                
                Console.WriteLine($" {cont} - {item.Descricao} R$ {item.Valor}");
                cont++;
            }
            Console.WriteLine($" {cont} - Sair");

            int.TryParse(Console.ReadLine(), out int op);
            return op;          

        }

    }
}
