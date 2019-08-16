using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoletimEscolar.Classes
{
    public class Aluno
    {
        static int contador;
        int id;
        string nome;
        double nota1;
        double nota2;
        double nota3;
        double media;
        double frequencia;        

        public string Nome { get => nome; set => nome = value; }
        public double Nota1 { get => nota1; set => nota1 = value; }
        public double Nota2 { get => nota2; set => nota2 = value; }
        public double Nota3 { get => nota3; set => nota3 = value; }
        public double Media { get => media; set => media = value; }
        public double Frequencia { get => frequencia; set => frequencia = value; }
        public int Id { get => id;}

        public Aluno(string pnome = "",double pn1 = 0, double pn2 = 0, double pn3 = 0,
                                            double pmedia = 0, double pfrequencia = 0)
        {
            contador++;
            id = contador;
            nome = pnome;
            nota1 = pn1;
            nota2 = pn2;
            nota3 = pn3;
            media = pmedia;
            frequencia = pfrequencia;
        }

       
    }
}
