using System;

namespace _5_exemploDateTime {
    internal class Program {
        static void Main(string[] args) {

            // mostra a data de hoje com hora zerada
            DateTime d1 = DateTime.Today;
            Console.WriteLine(d1);

            // mostra a data e horario atual
            DateTime d2 = DateTime.Now;
            Console.WriteLine(d2);

            // Horario no GMT
            DateTime d3 = DateTime.UtcNow;
            Console.WriteLine(d3);

            Console.WriteLine();
            // Ticks mostra quantos nanos segundos passaram desde o primeiro dia do ano.
            Console.WriteLine(d1.Ticks);

            Console.WriteLine();
            // instaciando e escolhendo a hora e data
            DateTime d4 = new DateTime(1994, 12, 24);
            Console.WriteLine(d4);
            DateTime d5 = new DateTime(1994, 12, 24, 23, 55, 10);
            Console.WriteLine(d5);

            Console.WriteLine();
            // conversao: exemplo com variavel e exemplo estanciando
            string exem1 = "2000-08-15";
            DateTime d6 = DateTime.Parse(exem1);
            Console.WriteLine(d6);
            DateTime d7 = DateTime.Parse("2001-09-16 13:05:58");
            Console.WriteLine(d7);
            DateTime d8 = DateTime.Parse("01/04/2022 15:17:55");
            Console.WriteLine(d8);


        }
    }
}
