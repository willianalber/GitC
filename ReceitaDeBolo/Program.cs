using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReceitaDeBolo
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] receita = new string[15]
                    {" ================ MODO DE PREPARO ==============",
                    "* 2 xícaras (chá) de açúcar ",
                    "* 3 xícaras (chá) de farinha de trigo ",
                    "* 4 colheres (sopa) de margarina ",
                    "* 3 ovos ",
                    "* 1 e 1/2 xícara (chá) de leite ",
                    "* 1 colher (sopa) bem cheia de fermento em pó ",
                    "================ MODO DE PREPARO ================",
                    "1° Bata as claras em neve e reserve.",
                    "2° Misture as gemas, a margarina e o açúcar até obter uma massa homogênea.",
                    "3° Acrescente o leite e a farinha de trigo aos poucos, sem parar de bater. ",
                    "4º Por último, adicione as claras em neve e o fermento.",
                    "5º Despeje a massa em uma forma grande de furo central untada e enfarinhada. ",
                    "6º Asse em forno médio 180 °C, preaquecido, por aproximadamente 40 minutos\nou ao furar o bolo com um garfo, este saia limpo.",
                    "==================== FIM =++====================="
                    };
          
            foreach (var linha in receita)
            {
                Console.ReadKey();
                Console.WriteLine(linha);          
            }

        }
    }
}
