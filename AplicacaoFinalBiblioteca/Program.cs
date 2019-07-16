using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinalConsole
{
    class Program
    {
        static string[,] listaDeLivros = new string[2, 6]
        {
            {"1","O Lobo","Carlos Drumon de Andrade","Sim","Ativo","" },
            {null,null,null,null,null,null}
        };
        static string[,] livro = new string[1, 6];
        static void Main(string[] args)
        {            
            mostraLogoSistema();
            int opcao = mostraMenu();
            while (opcao != 8)
            {
                verificaOpcao(opcao);
                opcao = mostraMenu();
            }

        }

        public static void verificaOpcao(int opcao)
        {
            switch (opcao)
            {
                case 1 : { OpcaoPesquisarLivro(); }break;
                case 2 : { OpcaoListarLivros(); }break;
                case 3 : { OpcaoListarLivros("Inativo"); }break;
                case 4 : { OpcaoAlocar(); };break;
            }               
        }

        private static void OpcaoAlocar()
        {
            
        }

        public static void OpcaoListarLivros(string LivrosAtivos = "Ativo")
        {
            mostraLogoSistema();
            for (int i = 0; i < listaDeLivros.GetLength(0); i++)
            {
                if (LivrosAtivos == "Ativo")
                {
                    if (listaDeLivros[i, 4] == LivrosAtivos)
                    {
                        Console.WriteLine(string.Format("ID: {0} Nome: {1} Autor: {2} Disponibilidade: {3} Situaçao: {4}", listaDeLivros[i, 0], listaDeLivros[i, 1], listaDeLivros[i, 2], listaDeLivros[i, 3], listaDeLivros[i, 4]));
                    }
                }
                else if (LivrosAtivos == "Inativo")
                {
                    if (listaDeLivros[i, 4] == LivrosAtivos)
                    {
                        Console.WriteLine(string.Format("ID: {0} Nome: {1} Autor: {2} Data de Exclusão: (3)", listaDeLivros[i, 0], listaDeLivros[i, 1], listaDeLivros[i, 2], listaDeLivros[i, 5]));
                    }
                }
           
            }
            Console.ReadKey();
        }

        public static void mostraLogoSistema()
        {
            Console.Clear();
            Console.WriteLine("=================================================================");
            Console.WriteLine("                      Bibioteca HBSIS                            ");
            Console.WriteLine("=================================================================");
        }

        public static int mostraMenu()
        {
            mostraLogoSistema();
            Console.WriteLine("1- Pesquisar por um livro");
            Console.WriteLine("2- Listar todos os livros ativos");
            Console.WriteLine("3- Listar todos os livros inativos");
            Console.WriteLine("4- Alocar um livro");
            Console.WriteLine("5- Desalocar um livro");
            Console.WriteLine("6- Excluir um livro");
            Console.WriteLine("7- Cadastrar um livro");
            Console.WriteLine("8- Sair");
            Console.WriteLine("\nEscolha uma das opções acima:");
            int.TryParse(Console.ReadKey().KeyChar.ToString(), out int opcao);

            return opcao;
        }

        public static void aumentarArray(ref string[,] listaDeLivros)
        {
            if (listaDeLivros[listaDeLivros.GetLength(0),0] == null)
            {
                return;
            }
            var copiaListaDeLivros = listaDeLivros;
            listaDeLivros = new string[listaDeLivros.GetLength(0) + 1, 5];
            for (int i = 0; i < copiaListaDeLivros.GetLength(0); i++)
            {
                for (int a = 0;  a < 5;  a++)
                {
                    listaDeLivros[i, a] = copiaListaDeLivros[i, a];
                }
            }
        }

        public static void OpcaoPesquisarLivro()
        {
            mostraLogoSistema();
            Console.WriteLine("Digite o nome do livro a ser pesquisado: ");
            string livroPesquisado = Console.ReadLine();
            if (!LivroExiste(livroPesquisado))
            {
                Console.WriteLine("Desculpe, mas não foi possivel encontrar o livro digitado... Deseja tentar pesquisar novamente? (1)-Sim (2)-Não");
                if (Console.ReadKey().KeyChar.ToString() == "1")
                {
                    OpcaoPesquisarLivro();
                }
            }
        }


        public static bool LivroExiste(string livroPesquisado)
        {
            for (int i = 0; i < listaDeLivros.GetLength(0); i++)
            {
                if (listaDeLivros[i, 1] != null)
                {
                    if (livroPesquisado.ToLower().Replace(" ", "") == listaDeLivros[i, 1].ToLower().Replace(" ", "") && listaDeLivros[i, 4] != "Inativo")
                    {
                        Console.WriteLine(string.Format("ID: {0} Nome: {1} Autor: {2} Disponibilidade: {3}", listaDeLivros[i, 0], listaDeLivros[i, 1], listaDeLivros[i, 2], listaDeLivros[i, 3]));
                        Console.WriteLine("pressione qualquer tecla para retornar ao menu inicial...");
                        Console.ReadKey();
                        return true;
                    }
                }
            };
            return false;
        }
    }
}
