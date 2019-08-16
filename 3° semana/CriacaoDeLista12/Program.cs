using CriacaoDeLista12.ObjetoLista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriacaoDeLista_
{
    class Program
    {
        //Versão 2.0 agora com nome correto
        static void Main(string[] args)
        {
            var lista = new Lista();
            lista.carregaLista();
            lista.mostraLista();
            lista.limpaLista();
            lista.mostraLista();
            Console.ReadKey();

           


        }
    }
}