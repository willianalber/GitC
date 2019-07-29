using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCantinaGG1.Classes
{
    class Aluno
    {
        String nome;
        int idade;
        double saldo;

        public double Saldo { get { return this.saldo; } }

        public Aluno(string pNome, int pIdade)
        {
            nome = pNome;
            idade = pIdade;
            saldo = 20;
        }

        public bool Sacar(double valor)
        {
            if (valor <= this.saldo)
            {
                this.saldo -= valor;
                return true;
            }
            return false;
        }

    }
}
