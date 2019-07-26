using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoletimEscolar.Classes
{
    public class CalculadorDeMedia
    {   
        
        public static double Media(double n1, double n2, double n3)
        {
            
            return (n1 + n2 + n3) / 3;
        }

        public static double frequencia(int totalDeAulas, int numeroDeFaltas)
        {
            return 100 - ((numeroDeFaltas * 100) / totalDeAulas);             
        }

        public static string Situacao(double pMedia, double pPresença)
        {
            return pMedia >= 7 && pPresença >= 75 ? "Aprovado" : "Reprovado";
        }
    }
}
