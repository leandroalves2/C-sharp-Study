using System;

namespace _7_exemploTimeKind {
    internal class Program {
        static void Main(string[] args) {

            // DateTimeKind

            DateTime d1 = new DateTime(2023, 02, 26, 12, 30, 15);
            DateTime d2 = new DateTime(2023, 02, 26, 12, 30, 15, DateTimeKind.Local);
            DateTime d3 = new DateTime(2023, 02, 26, 12, 30, 15, DateTimeKind.Utc);

            // no D1 eu nao especifiquei o tipo, entao ele subtrair 3 horas no local e adicionar 3h no UTC           
            Console.WriteLine("d1: " + d1);
            Console.WriteLine("d1 Tipo: " + d1.Kind);
            Console.WriteLine("d1 to Local: " + d1.ToLocalTime());
            Console.WriteLine("d1 to Utc: " + d1.ToUniversalTime());
            Console.WriteLine();

            Console.WriteLine("d2: " + d2);
            Console.WriteLine("d2 Kind: " + d2.Kind);
            Console.WriteLine("d2 to Local: " + d2.ToLocalTime());
            Console.WriteLine("d2 to Utc: " + d2.ToUniversalTime());
            Console.WriteLine();

            Console.WriteLine("d3: " + d3);
            Console.WriteLine("d3 Kind: " + d3.Kind);
            Console.WriteLine("d3 to Local: " + d3.ToLocalTime());
            Console.WriteLine("d3 to Utc: " + d3.ToUniversalTime()); ;
        }
    }
}
