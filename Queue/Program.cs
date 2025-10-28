using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    class Program
    {
        static Queue<string> pedagio = new Queue<string>();
        static void Main(string[] args)
        {
            // string veiculo = "van";
            Enfileirar("Van");
            Enfileirar("Kombi");
            Enfileirar("Guincho");
            Enfileirar("Pickup");

            Desenfileirar();
            Desenfileirar();
            Desenfileirar();
            Desenfileirar();
            Desenfileirar();

            Console.ReadLine();
        }

        private static void Desenfileirar()
        {
            if (pedagio.Any())
            {
                if(pedagio.Peek() == "Guincho")
                {
                    Console.WriteLine("Guincho está fazendo pagamento");
                }

                string veiculo = pedagio.Dequeue();
                Console.WriteLine($"Saiu da fila: {veiculo}");
                ImprimirFila();

            }
            
        }

        private static void Enfileirar(string veiculo)
        {
            Console.WriteLine($"Entrou na fila: {veiculo}");

            pedagio.Enqueue(veiculo);
            ImprimirFila();
        }

        private static void ImprimirFila()
        {
            Console.WriteLine("Fila: ");
            foreach (var v in pedagio)
            {
                Console.WriteLine(v);
            }
            Console.WriteLine();
        }
    }
}
