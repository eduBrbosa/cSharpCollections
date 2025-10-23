using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            string aulaIntro = "Introdução às Coleções";
            string aulaModelando = "Modelando a Classe Aula";
            string aulaSets = "Trabalhando com Conjuntos";

            //string[] aulas = new string[]
            //{
            //    aulaIntro,
            //    aulaModelando,
            //    aulaSets
            //};

            string[] aulas = new string[3];

            aulas[0] = aulaIntro;
            aulas[1] = aulaModelando;
            aulas[2] = aulaSets;
            Imprimir(aulas);
            Console.WriteLine();

            Console.WriteLine(aulas[0]);
            Console.WriteLine(aulas[aulas.Length-1]);

            Console.WriteLine();
            aulas[0] = "Trabalhando com Arrays";
            Imprimir(aulas);
            Console.WriteLine();

            Console.WriteLine($"Aula modelando está no índice {Array.IndexOf(aulas, aulaModelando)}");
            Console.WriteLine(Array.LastIndexOf(aulas, aulaModelando));
            Console.WriteLine();

            Array.Reverse(aulas);
            Imprimir(aulas);
            Console.WriteLine();

            Array.Resize(ref aulas, 2);
            Imprimir(aulas);
            Console.WriteLine();

            Array.Resize(ref aulas, 3);
            Imprimir(aulas);
            Console.WriteLine();

            aulas[aulas.Length - 1] = "Conclusão";
            Imprimir(aulas);
            Console.WriteLine();

            Array.Sort(aulas);
            Imprimir(aulas);
            Console.WriteLine();


            string[] copia = new string[2];
            Array.Copy(aulas, 1, copia, 0, 2);
            Imprimir(copia);
            Console.WriteLine();


            string[] clone = aulas.Clone() as string[];
            Imprimir(clone);
            Console.WriteLine();


            Array.Clear(clone, 1, 2);
            Imprimir(clone);
            Console.WriteLine();

            Console.ReadLine();

        }

        private static void Imprimir(string[] aulas)
        {
            //foreach (var aula in aulas)
            //{
            //    Console.WriteLine(aula);
            //}

            for (int i = 0; i < aulas.Length; i++)
            {
                Console.WriteLine(aulas[i]);
            }

        }
    }
}
