using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoletimEscolar.Classes
{
    public class Cadastro
    {
        public static void realizarCadastro(ref List<Aluno> listaDeAlunos)
        {
            

            Console.WriteLine("Digite o Nome do aluno: ");
            String nome = Console.ReadLine();
            Console.WriteLine("Digite a 1° nota: ");
            double.TryParse(Console.ReadLine(), out double n1);
            Console.WriteLine("Digite a 2° nota: ");
            double.TryParse(Console.ReadLine(), out double n2);
            Console.WriteLine("Digite a 3° nota: ");
            double.TryParse(Console.ReadLine(), out double n3);
            Console.WriteLine("Digite o total de aulas: ");
            int.TryParse(Console.ReadLine(), out int totalAulas);
            Console.WriteLine("Digite a quntidade de faltas: ");
            int.TryParse(Console.ReadLine(), out int faltas);

            

            double media = CalculadorDeMedia.Media(n1, n2, n3);
            double frequencia = CalculadorDeMedia.frequencia(totalAulas, faltas);

            Console.WriteLine("Média: " + media);
            Console.WriteLine("Frequencia: " + frequencia + "%");
            Console.WriteLine("Situação: " + CalculadorDeMedia.Situacao(media, frequencia));

            listaDeAlunos = ManipularListaDeAlunos.InserirAluno(listaDeAlunos, nome, n1, n2, n3, media, frequencia);

            Console.ReadKey();
        }
    }
}
