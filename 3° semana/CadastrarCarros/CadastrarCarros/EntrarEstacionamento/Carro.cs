using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastrarCarros.EntrarEstacionamento
{
    class Carro
    {
        string modelo;
        string placa;
        string horaEntrada;
        string horaSaida;

        public string Modelo { get => modelo; set => modelo = value; }
        public string Placa { get => placa; set => placa = value; }
        public string HoraEntrada { get => horaEntrada; set => horaEntrada = value; }
        public string HoraSaida { get => horaSaida; set => horaSaida = value; }

        public Carro RegistrarEntrada(Carro pCarro)
        {
            Console.Clear();
            Console.WriteLine("Modelo: ");
            pCarro.modelo = Console.ReadLine();
            Console.WriteLine("Placa: ");
            pCarro.placa = Console.ReadLine();
            Console.WriteLine($" -------------------------------------------- Data e hora atual: {DateTime.Now.ToString("dd/MM/yyy hh:mm:ss")}\n" +
                              $"Digite a data e hora da entrada do veiculo ou pressione enter para inserir a data e hora atual");
            string entrada = Console.ReadLine();
            if (entrada.Replace(" ","") == "")
            {
                entrada = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss");
            }
            pCarro.horaEntrada = entrada;
            pCarro.HoraSaida = null;

            return pCarro;
        }

        public static void listarRegistros()
        {

        }


    }
}
