using System;
using System.Globalization;

namespace Problema_exemplo_circunferência {
    internal class Program {
        static void Main(string[] args) {

            CultureInfo ci = CultureInfo.InvariantCulture;

            Console.Write("Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), ci);

            Console.WriteLine("Circunferência: " + Circulo.Area(raio).ToString("F2", ci));
            Console.WriteLine("Volume: " + Circulo.Volume(raio).ToString("F2", ci));
            Console.WriteLine("Valor de PI: " + Circulo.Pi);

        }
    }
}
