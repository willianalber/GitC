using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaDeArquivosDoWindows;

namespace MinhaPrimeiraBibiotecaOnline
{
    class Program
    {
        static void Main(string[] args)
        {
            var objeto = new GetFiles();
                        
            
            foreach (var item in objeto.RetornaArquivosDoMeuDocumentos())
            {
                Console.WriteLine(item);
            }
            foreach (var item in objeto.RetornaArquivosImagesFiles())
            {
                Console.WriteLine(item);
            }
            foreach (var item in objeto.RetornaArquivosGit())
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
