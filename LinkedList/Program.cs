using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> dias = new LinkedList<string>();

            var d4 = dias.AddFirst("Quarta");
            //Console.WriteLine(d4.Value);
            
            var d2 = dias.AddBefore(d4, "Segunda");
            var d3 = dias.AddAfter(d2, "Terça");
            var d6 = dias.AddAfter(d4, "Sexta");
            var d7 = dias.AddAfter(d6, "Sábado");
            var d5 = dias.AddBefore(d6, "Quinta");
            var d1 = dias.AddBefore(d2, "Domingo");

            foreach(var dia in dias)
            {
                Console.WriteLine(dia);
            }
            Console.WriteLine();

            var quarta = dias.Find("Quarta");

            dias.Remove("Quarta");
            foreach (var dia in dias)
            {
                Console.WriteLine(dia);
            }

            Console.ReadLine();
        }
    }
}
 