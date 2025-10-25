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

            cSharpColecoes.Adiciona(new Aula("Criando uma Aula", 20));
            cSharpColecoes.Adiciona(new Aula("Modelando com Coleções", 19));


            Imprimir(cSharpColecoes.Aulas);


            List<Aula> aulasCopiadas = new List<Aula>(cSharpColecoes.Aulas);

            aulasCopiadas.Sort();
            Imprimir(aulasCopiadas);
            Console.WriteLine();


            Console.WriteLine(cSharpColecoes.TempoTotal);
            Console.WriteLine(cSharpColecoes);

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
