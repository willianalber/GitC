using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaBiDeManeiraSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] listaDeNome = new string[5, 2];

            carregaInformacoesEListaElasEmTela(ref listaDeNome);


            Console.WriteLine("Informe o ID do registro a ser pesquisado: ");
            PesquisandoInformacoesElistaElasEmTela(ref listaDeNome, Console.ReadLine());



            
            Console.ReadKey();
        }

        private static void PesquisandoInformacoesElistaElasEmTela(ref string[,] listaDeNome, string pid)
        {
            for (int i = 0; i < listaDeNome.GetLength(0); i++)
            {
                if(listaDeNome[i,0] == pid)
                {
                    Console.WriteLine($"Informação escolhida : Id: {listaDeNome[i,0]} - Nome: {listaDeNome[i,1]}");
                    return;
                }
            }
        }

        /// <summary>
        /// Metodo que carrega as informações dentro da lista
        /// </summary>
        /// <param name="listaDeNome"></param>
        private static void carregaInformacoesEListaElasEmTela(ref string[,] listaDeNome)
        {
            for (int i = 0; i < listaDeNome.GetLength(0); i++)
            {
                listaDeNome[i, 0] = i.ToString();
                listaDeNome[i, 1] = $"Wllian_{i}";
            }

            
            for (int i = 0; i < listaDeNome.GetLength(0); i++)
            {
                Console.WriteLine($"ID: {listaDeNome[i, 0]} - Nome: {listaDeNome[i, 1]}");
            }
        }
    }
}
