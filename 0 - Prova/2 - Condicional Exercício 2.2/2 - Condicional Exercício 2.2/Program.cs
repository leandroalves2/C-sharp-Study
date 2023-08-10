using System;
using System.Globalization;


namespace _2___Condicional_Exercício_2._2 {
    internal class Program {
        static void Main(string[] args) {

            CultureInfo ci = CultureInfo.InvariantCulture;
            double a, b, c, delta, x1, x2;

            Console.Write("Digite o valor de A: ");
            a = double.Parse(Console.ReadLine(), ci);
            Console.Write("Digite o valor de B: ");
            b = double.Parse(Console.ReadLine(), ci);
            Console.Write("Digite o valor de C: ");
            c = double.Parse(Console.ReadLine(), ci);

            delta = Math.Pow(b, 2) - 4 * a * c;

            if (delta <= 0 || a == 0 || b == 0 || c == 0) {
                Console.WriteLine("Impossivel calcular");
            }
            else {
                x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                x2 = (-b - Math.Sqrt(delta)) / (2 * a);

                Console.WriteLine("X1 = " + x1.ToString("F5", ci));
                Console.WriteLine("X2 = " + x2.ToString("F5", ci));

            }
        }
    }
}
