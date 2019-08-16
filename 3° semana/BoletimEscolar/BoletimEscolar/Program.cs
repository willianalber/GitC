using BoletimEscolar.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoletimEscolar
{
    class Program
    {
        public static List<Aluno> listaDeAlunos = new List<Aluno>();
        static void Main(string[] args)
        {
            
            while (true)
            {
                int op = MostrarMenu();
                if (op == 1)
                {
                    Console.Clear();
                    Cadastro.realizarCadastro(ref listaDeAlunos);
                }
                else if (op == 2)
                {
                    Console.Clear();
                    ManipularListaDeAlunos.ListarAlunos(listaDeAlunos);
                }
                else if (op == 3)                
                {
                    Console.Clear();
                    ManipularListaDeAlunos.ListarAlunos(listaDeAlunos);
                    Console.WriteLine("Digite o Id do registro que desejas excluir");
                    int.TryParse(Console.ReadLine(), out int Id);
                    if (ManipularListaDeAlunos.excluirRegistro(ref listaDeAlunos, Id))
                    {
                        Console.WriteLine("Registro excluido com sucesso!");
                    }
                    else
                    {
                        Console.WriteLine("Ops, não foi possivel excluir o registro ou o ID informado não existe. Verifique!");
                    }
                    Console.ReadKey();
                    // criar o método excluir um registro
                }
                else if (op == 4)
                {
                    Console.Clear();
                    ManipularListaDeAlunos.ListarAlunos(listaDeAlunos);
                    Console.WriteLine("Digite o Id do registro que desejas alterar");
                    int.TryParse(Console.ReadLine(), out int Id);
                    if (ManipularListaDeAlunos.AlterarRegistro(ref listaDeAlunos, Id))
                    {
                        Console.WriteLine("Registro alterado com sucesso!");
                    }
                    else
                    {
                        Console.WriteLine("Ops, não foi possivel alterar o registro ou o ID informado não existe. Verifique!");
                    }
                    Console.ReadKey();
                    // criar o método alterar notas de um registro e recalcular a media
                }
                else
                {
                    break;
                }
            }
            
            
            


        }

        public static int MostrarMenu()
        {
            Console.WriteLine("==================================");
            Console.WriteLine("Escolha uma das opções abaixo:");
            Console.WriteLine(" 1 - Inserir aluno");
            Console.WriteLine(" 2 - Listar todos os alunos");
            Console.WriteLine(" 3 - Excluir um registro");
            Console.WriteLine(" 4 - Alterar as notas de um registro");
            int.TryParse(Console.ReadKey().KeyChar.ToString(), out int op);
            return op; 
        }
    }
}
