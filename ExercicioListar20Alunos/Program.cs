using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioListar20Alunos
{
    class Program
    {
        static void Main(string[] args)
        {
            String[,] alunos = new string[20, 3]
                {{"Willian","25","Masculino"},
                {"Cristiano","26","Masculino"},
                {"Chayane","16","Feminino"},
                {"Victor","13","Masculino"},
                {"Elisa","18","Feminino"},
                {"Gabriel","21","Masculino"},
                {"Tauane","23","Feminino"},
                {"Robson","25","Masculino"},
                {"Antonela","21","Feminino"},
                {"Afonso","48","Masculino"},
                {"David","25","Masculino"},
                {"Natan","26","Masculino"},
                {"Julia","16","Feminino"},
                {"Marcos","13","Masculino"},
                {"Fulana","18","Feminino"},
                {"Ciclano","21","Masculino"},
                {"Felisbina","23","Feminino"},
                {"Anotnio","25","Masculino"},
                {"Ferminia","21","Feminino"},
                {"Diego","48","Masculino"} };

            for (int i = 0; i < alunos.GetLength(0); i++)
            {
                Console.WriteLine($"nome: {alunos[i, 0]} idade: {alunos[i, 1]} sexo: {alunos[i, 2]}");
            }
            Console.ReadKey();
        }        
    }
}
