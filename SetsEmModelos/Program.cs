using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetsEmModelos
{
    class Program
    {
        static void Main(string[] args)
        {
            Curso cSharpColecoes = new Curso("C# Colecoes", "Marcelo Oliveira");

            cSharpColecoes.Adiciona(new Aula("Trabalhando com Listas", 21));
            cSharpColecoes.Adiciona(new Aula("Criando uma Aula", 20));
            cSharpColecoes.Adiciona(new Aula("Modelando com Colecoes", 24));

            Aluno a1 = new Aluno("Vitória Correa", 34561);
            Aluno a2 = new Aluno("Pierre dos Santos", 34935);
            Aluno a3 = new Aluno("Eduardo Dias", 34672);

            cSharpColecoes.Matricula(a1);
            cSharpColecoes.Matricula(a2);
            cSharpColecoes.Matricula(a3);


            Console.WriteLine("Imprimindo os alunos matriculados: ");
            foreach (var aluno in cSharpColecoes.Alunos)
            {
                Console.WriteLine(aluno.ToString());                
            }


            Console.ReadLine();
        }
    }
}
