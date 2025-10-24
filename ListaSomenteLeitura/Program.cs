using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaSomenteLeitura
{
    class Program
    {
        static void Main(string[] args)
        {

            var cSharpColecoes = new Curso("C# Collections", "Marcelo Oliveira");

            cSharpColecoes.Adiciona(new Aula("Trabalhando com listas", 21));

            Imprimir(cSharpColecoes.Aulas);

            Console.ReadLine();
        }

        private static void Imprimir(IList<Aula> aulas)
        {
            Console.Clear();

            foreach (var aula in aulas)
            {
                Console.WriteLine(aula);
            }

        }

    }
}
