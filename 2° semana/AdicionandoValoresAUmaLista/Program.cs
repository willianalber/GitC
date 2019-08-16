using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdicionandoValoresAUmaLista
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] listaDeNome = new string[10,2];

            int idParaLista = 0;

            InsereRegistro(ref listaDeNome, ref idParaLista);           

            Console.ReadKey();

            InsereRegistro(ref listaDeNome, ref idParaLista);

            Console.ReadKey();
        }

        public static void InsereRegistro(ref string[,] listaDeNome, ref int idParaLista)
        {
            for (int i = 0; i < listaDeNome.GetLength(0); i++)
            {
                if (listaDeNome[i,0] != null)
                {
                    continue;
                }

                Console.WriteLine("Informe um nome para adicinar um registro: ");
                var nome = Console.ReadLine();
                listaDeNome[i, 0] = (idParaLista++).ToString();
                listaDeNome[i, 1] = nome;

                Console.WriteLine("Deseja inserir um outro registro ? sim(1) não(0)");
                var continuar = Console.ReadKey().KeyChar.ToString();

                if (continuar == "0")
                {
                    break;
                }

                AumentarTamanhoLista(ref listaDeNome);

            }

            Console.WriteLine("Registro adicionado com sucesso! Segue a lista com os registros adiciondos...");

            for (int i = 0; i < listaDeNome.GetLength(0); i++)
            {
                Console.WriteLine(string.Format("Registro: ID {0} - Nome {1}", listaDeNome[i, 0], listaDeNome[i, 1]));
            }
        }

        public static void AumentarTamanhoLista(ref string[,] ListadeNome)
        {
            var limite = true;

            for (int i = 0; i < ListadeNome.GetLength(0); i++)
            {
                if (ListadeNome[i,0] == null)
                {
                    limite = false;
                }

                if (limite) 
                {
                    var listaCopia = ListadeNome;

                    ListadeNome = new string[ListadeNome.GetLength(0) + 5, 2];

                    for (int i = 0; i < listaCopia.GetLength(0); i++)
                    {
                        ListadeNome[i, 0] = listaCopia[i, 0];
                        ListadeNome[i, 1] = listaCopia[i, 1];
                    }

                    Console.WriteLine("O tamanho da lista foi atualizado.");
                }
            }
        }
    }
}
