using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCantinaGG1.Classes
{
    class Lanches
    {
        string descricao;
        double valor;

        public string Descricao { get => descricao; set => descricao = value; }
        public double Valor { get => valor; set => valor = value; }

        public Lanches(string descricao, double valor)
        {
            this.descricao = descricao;
            this.valor = valor;
        }
    }
}
