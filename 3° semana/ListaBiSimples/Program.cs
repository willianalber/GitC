using ListaBiSimples.Carrega;
using ListaBiSimples.Mostrar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaBiSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criando nossa lista com mais de uma dimensão
            string[,] listaDeNome = new string[5, 2];
            //Aqui iniciamos o objeto em memória
            var carregaLista = new CarregarLista();
            //
            carregaLista.CarregaInformacoesEListaElasEmTela(listaDeNome);

            var mostrarLista = new MostrarLista();

            mostrarLista.PesquisandoInformacoesNaNossaLista(listaDeNome,"0");

            mostrarLista.CarregaInformacoesEListaElasEmTela(listaDeNome);

            Console.ReadKey();
        }
    }
}
