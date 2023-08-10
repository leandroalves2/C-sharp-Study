using System;
using System.Globalization;

namespace Atividade_Triangulo {
    internal class Program {
        static void Main(string[] args) {

            CultureInfo ci = CultureInfo.InvariantCulture;

            Triangulo x = new Triangulo();
            Triangulo y = new Triangulo();

            Console.WriteLine("Entre com as medidas do triângulo X: ");
            x.A = double.Parse(Console.ReadLine(), ci);
            x.B = double.Parse(Console.ReadLine(), ci);
            x.C = double.Parse(Console.ReadLine(), ci);

            Console.WriteLine();
            Console.WriteLine("Entre com as medidas do triângulo Y: ");
            y.A = double.Parse(Console.ReadLine(), ci);
            y.B = double.Parse(Console.ReadLine(), ci);
            y.C = double.Parse(Console.ReadLine(), ci);

            double areaX = x.Area();
            double areaY = y.Area();

            Console.WriteLine("Área de X = " + areaX.ToString("F4", ci));
            Console.WriteLine("Área de Y = " + areaY.ToString("F4", ci));

            if (areaX > areaY) {
                Console.WriteLine("Maior área: X");
            }
            else {
                Console.WriteLine("Maior área: Y");
            }

        }
    }
}
