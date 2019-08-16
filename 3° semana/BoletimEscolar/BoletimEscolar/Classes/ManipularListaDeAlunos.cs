using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoletimEscolar.Classes
{
    public class ManipularListaDeAlunos
    {
   
        public static void ListarAlunos(List<Aluno> aluno)
        {      
            foreach (var item in aluno)
            {
                Console.WriteLine($"==================================\n" +
                                  $"ID: {item.Id}\n" +
                                  $"Nome: {item.Nome} \n" +
                                  $"Nota 1: {item.Nota1} \n" +
                                  $"Nota 2: {item.Nota2} \n" +
                                  $"Nota 3: {item.Nota3} \n" +
                                  $"Media: {item.Media} \n" +
                                  $"Frequencia: {item.Frequencia} %\n" +
                                  $"Situacao: {CalculadorDeMedia.Situacao(item.Media,item.Frequencia)}\n" +
                                  $"==================================");
            }
        }

        public static List<Aluno> InserirAluno(List<Aluno> plistaDeAlunos, string pnome, 
                                            double pn1,double pn2, double pn3,
                                            double pmedia,double pfrequencia)
        {
            Aluno aluno = new Aluno(pnome, pn1, pn2, pn3, pmedia, pfrequencia);
            plistaDeAlunos.Ad d(aluno);    
            return plistaDeAlunos;
        }

        public static bool excluirRegistro(ref List<Aluno> pListaDeAlunos, int pId)
        {           
            for (int i = 0; i < pListaDeAlunos.Count; i++)
            {
                if (pListaDeAlunos[i].Id == pId)
                {
                    pListaDeAlunos.Remove(pListaDeAlunos[i]);
                    return true;                    
                }
            }
            return false;
        }

        public static bool AlterarRegistro(ref List<Aluno> pListaDeAlunos, int pId)
        {
            for (int i = 0; i < pListaDeAlunos.Count; i++)
            {
                if (pListaDeAlunos[i].Id == pId)
                {
                    Console.WriteLine("Digite a 1° nota: ");
                    double.TryParse(Console.ReadLine(), out double n1);
                    Console.WriteLine("Digite a 2° nota: ");
                    double.TryParse(Console.ReadLine(), out double n2);
                    Console.WriteLine("Digite a 3° nota: ");
                    double.TryParse(Console.ReadLine(), out double n3);
                    Console.WriteLine("Digite o total de aulas: ");
                    int.TryParse(Console.ReadLine(), out int totalAulas);
                    Console.WriteLine("Digite a quantidade de faltas: ");
                    int.TryParse(Console.ReadLine(), out int faltas);
                    pListaDeAlunos[i].Nota1 = n1;
                    pListaDeAlunos[i].Nota2 = n2;
                    pListaDeAlunos[i].Nota3 = n3;
                    pListaDeAlunos[i].Media = CalculadorDeMedia.Media(n1,n2,n3);
                    pListaDeAlunos[i].Frequencia = CalculadorDeMedia.frequencia(totalAulas, faltas);
                    return true;

                }
            }
            return false;
        }
    }
}
