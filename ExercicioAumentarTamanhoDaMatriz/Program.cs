using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioAumentarTamanhoDaMatriz
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] lista = new string[1, 3];

            int id = 0;

            cadastrarValores(ref lista, id);    
            while (true)
            {
                Console.WriteLine("Deseja cadastrar mais um usuario? (1)Sim (2)Não");
                int.TryParse(Console.ReadKey().KeyChar.ToString(), out int op);
                if (op == 2)
                {
                    break;
                }
                else if (op == 1)
                {
                    cadastrarValores(ref lista, id);
                }
                else
                {
                    Console.WriteLine("Opção invalida!");
                }
            }

            listarCadastros(ref lista);

        }

        private static void listarCadastros(ref string[,] lista)
        {
            for (int i = 0; i < lista.GetLength(0); i++)
            {
                if (lista[i, 0] != null)
                {
                    Console.WriteLine(string.Format("ID : {0} Nome: {1} Idade: {2}", lista[i, 0], lista[i, 1], lista[i, 2]));
                }                 
            }
            Console.ReadKey();
        }

        private static void cadastrarValores(ref string[,] lista, int id)
        {
            for (int i = 0; i < lista.GetLength(0); i++)
            {
                if (lista[i,0] != null)
                {
                    id++;
                    continue;
                }
                lista[i, 0] = id.ToString();
                Console.WriteLine("Informe o nome: ");
                lista[i, 1] = Console.ReadLine();
                Console.WriteLine("Informe a idade: ");
                lista[i, 2] = Console.ReadLine();               
                Console.WriteLine("Usuario cadastrado com sucesso!");       
            }
            AumentarTamanhoDaMatriz(ref lista);
        }

        private static void AumentarTamanhoDaMatriz(ref string[,] lista)
        {
            var copia = lista;
            lista = new string[lista.GetLength(0) + 1, 3];
            for (int i = 0; i < copia.GetLength(0); i++)
            {
                lista[i, 0] = copia[i, 0];
                lista[i, 1] = copia[i, 1];
                lista[i, 2] = copia[i, 2];
            }
        }
    }
}
