using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListandoCarros.Classes
{
    class Carro
    {
        public string Modelo { get; set; }
        public int Ano { get; set; }
        public string Placa { get; set; }
        public int Cv { get; set; }

        public static List<Carro> AddCarros(List<Carro> listaDeCarros)
        {
            listaDeCarros.Add
                (
                    new Carro()
                    {
                        Modelo = retornaAtributo("Modelo: "),
                        Ano = int.Parse(retornaAtributo("Ano: ")),
                        Placa = retornaAtributo("Placa: "),
                        Cv = int.Parse(retornaAtributo("Cavalos: "))

                    }
                );
            return listaDeCarros;

        }

        public static string retornaAtributo(string v)
        {
            Console.WriteLine(v);
            return Console.ReadLine();
        }
    }
}
