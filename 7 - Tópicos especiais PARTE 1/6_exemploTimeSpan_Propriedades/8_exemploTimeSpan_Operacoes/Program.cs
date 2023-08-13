using System;
namespace _8_exemploTimeSpan_Operacoes {
    internal class Program {
        static void Main(string[] args) {

            // Valores de TimeSpan
            TimeSpan t1 = TimeSpan.MaxValue;
            TimeSpan t2 = TimeSpan.MinValue;
            TimeSpan t3 = TimeSpan.Zero;
            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);

            //
            Console.WriteLine();
            TimeSpan t4 = new TimeSpan(2, 11, 45, 30, 250);
            Console.WriteLine(t4);
            Console.WriteLine("Dias: " + t4.Days);
            Console.WriteLine("Horas: " + t4.Hours);
            Console.WriteLine("Minutos: " + t4.Minutes);
            Console.WriteLine("Segundos: " + t4.Seconds);
            Console.WriteLine("Milisegundos: " + t4.Milliseconds);
            Console.WriteLine("Ticks: " + t4.Ticks);

            Console.WriteLine("Total de dias: " + t4.TotalDays);
            Console.WriteLine("Total de horas: " + t4.TotalHours);
            Console.WriteLine("Total de minutos: " + t4.TotalMinutes);
            Console.WriteLine("Total de segundos: " + t4.TotalSeconds);
            Console.WriteLine("Total de milisegundos: " + t4.TotalMilliseconds);


        }
    }
}
