using System;
using System.Globalization;

namespace _1___Sequencial_Exercício_1._2 {
    internal class Program {
        static void Main(string[] args) {

            CultureInfo ci = CultureInfo.InvariantCulture;

            Console.WriteLine("Digite o raio do circulo: ");
            double raio = double.Parse(Console.ReadLine(), ci);

            double area = 3.14159 * Math.Pow(raio, 2);

            Console.WriteLine("A area é = "+ area.ToString("F4", ci));

        }
    }
}
