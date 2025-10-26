using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sets
{
    class Program
    {
        static void Main(string[] args)
        {

            ISet<string> alunos = new HashSet<string>();

            alunos.Add("Vanessa Tonini");
            alunos.Add("Ana Losnak");
            alunos.Add("Rafael Nercessian");
            Console.WriteLine(string.Join(",\n", alunos));
            Console.WriteLine();

            alunos.Add("Vitória Correa");
            alunos.Add("Pierre dos Santos");
            alunos.Add("Eduardo Dias");
            Console.WriteLine(string.Join(",\n", alunos));
            Console.WriteLine();

            alunos.Remove("Ana Losnak");
            alunos.Add("Marcelo Oliveira");
            Console.WriteLine(string.Join(",\n", alunos));
            Console.WriteLine();

            alunos.Add("Eduardo Dias");
            Console.WriteLine(string.Join(",\n", alunos));
            Console.WriteLine();

            List<string> alunosEmLista = new List<string>(alunos);
            alunosEmLista.Sort();
            Console.WriteLine(string.Join(",\n", alunosEmLista));
            Console.WriteLine();


            Console.ReadLine();
            
        }
    }
}
