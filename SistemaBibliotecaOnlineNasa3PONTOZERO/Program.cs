using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBibliotecaOnlineNasa3PONTOZERO
{
    class Program
    {
        static string[,] baseDeLivro;
        static void Main(string[] args)
        {
            CarregaBaseDeDados();
            mostrarSejaBemVindo();  

            if (MenuInicial() == 1)
            {
                MostrarMenuAlocacao();                
            }

            Console.ReadKey();
        }


        /// <summary>
        /// Metodo mostra o conteudo o menu e as opções de escolha.
        /// </summary>
        /// <returns>Retorna o valor do menu escolhido em um tipo inteiro</returns>
        private static int MenuInicial()
        {
            Console.WriteLine("O que você deseja realizar ?");
            Console.WriteLine("1- Alocar um livro.");
            Console.WriteLine("2- Sair do sistema.");
            Console.WriteLine("Digite o número desejado: ");

            int.TryParse(Console.ReadKey().KeyChar.ToString(), out int opcao);

            return opcao;
        }
        /// <summary>
        /// Metodo mostra o seja bem vindo da tela inicial.
        /// </summary>
        /// <returns>não retorna nada</returns>
        public static void mostrarSejaBemVindo()
        {
            Console.WriteLine("________________________________________________");
            Console.WriteLine("       Sistema de alocação de livros.");
            Console.WriteLine("________________________________________________");
            Console.WriteLine("      Desenvolvido pelas industrias HBSIS");
            Console.WriteLine("________________________________________________");
        }

        /// <summary>
        /// Metodo que carrega a base de dados dentro do sistema.
        /// </summary>
        public static void CarregaBaseDeDados()
        {
            baseDeLivro = new string[2, 2] 
            { 
                { "O pequeno", "sim" }, 
                { "O grande", "não" }
            };
        }

        /// <summary>
        /// Metodo que retorna se um livro pode ser locado.
        /// </summary>
        /// <param name="nomeLivro"> nome do livro a ser pesquisado</param>
        /// <returns>retorna verdadeiro caso o livro esteja disponivel</returns>
        private static bool PesquisaLivroParaLocacao(string nomeLivro)
        {
            for (int i = 0; i < baseDeLivro.GetLength(0); i++)
            {
                if (nomeLivro == baseDeLivro[i, 0])
                {
                    Console.WriteLine($"O livro {nomeLivro} " +
                                      $"pode ser locado?: { baseDeLivro[i, 1]}");

                    return  baseDeLivro[i, 1] == "sim";

                }

            }
            return false; 
        }
        /// <summary>
        /// Metodo que aloca o livro de acordo com o parametro passado.
        /// </summary>
        /// <param name="nomeLivro">Nome do livro a ser alocado.</param>
        public static void AlocarLivro(string nomeLivro)
        {
            for (int i = 0; i < baseDeLivro.GetLength(0); i++)
            {
                if (nomeLivro == baseDeLivro[i, 0])
                {
                    baseDeLivro[i, 1] = "não";
                }
            }
        }
        /// <summary>
        /// Metodo para mestrar o menu de alocação
        /// </summary>
        public static void MostrarMenuAlocacao()
        {
            Console.Clear();

            mostrarSejaBemVindo();
            Console.WriteLine("\r\nMenu alocação de Livros");
            Console.WriteLine("Digite o nome do livro a ser locado: ");

            var nomeLivro = Console.ReadLine();

            if (PesquisaLivroParaLocacao(nomeLivro))
            {
                Console.Clear();
                Console.WriteLine("Você deseja alocar o livro? para sim(1) para não(0)");
                if (Console.ReadKey().KeyChar.ToString() == "1")
                {
                    AlocarLivro(nomeLivro);
                    Console.Clear();
                    Console.WriteLine("Livro Alocado com sucesso!");
                }
                else
                    Console.Clear();

                Console.WriteLine("Listagem de livros:");

                for (int i = 0; i < baseDeLivro.GetLength(0); i++)
                {
                    Console.WriteLine($"Nome: {baseDeLivro[i, 0]} Disponivel: {baseDeLivro[i, 1]}");
                }
            }

        }

    }

}
