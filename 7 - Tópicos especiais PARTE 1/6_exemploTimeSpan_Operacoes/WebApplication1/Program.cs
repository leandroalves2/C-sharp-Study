using System;

namespace _8_exemploTimeSpan_Operacoes {
    internal class Program {
        static void Main(string[] args) {

            // Foi necessario abrir o projeto como aplicativo de console Net Core WEB que foi unico c# netcore que achei
            // as operações divisao e multiplicação estao apenas nas versoes net core 2.0 em diante.

            //Valores inciais
            TimeSpan t1 = new TimeSpan(12, 00, 00);
            Console.WriteLine(t1);
            TimeSpan t2 = new TimeSpan(0, 30, 10);
            Console.WriteLine(t2);

            //operaçoes
            Console.WriteLine();
            TimeSpan sum = t1.Add(t2);
            Console.WriteLine("Somando as duas horas: " + sum);

            TimeSpan dif = t1.Subtract(t2);
            Console.WriteLine("Subtraindo as datas: " + dif);

            TimeSpan mult = t2.Multiply(2.0);
            Console.WriteLine("Multiplicação: " + mult);

            TimeSpan div = t2.Divide(2);
            Console.WriteLine("Divisao: " + div);

            Console.WriteLine();
        }
    }
}
