using System;
using System.Globalization;

namespace ExercicioTriangulo {
    class Program {
        static void Main(string[] args) {

            CultureInfo ci = CultureInfo.InvariantCulture;
            Triangulo x = new Triangulo();
            Triangulo y = new Triangulo();

            Console.WriteLine("Entre com as medidas do triângulo X: ");
            x.A = double.Parse(Console.ReadLine(), ci);
            x.B = double.Parse(Console.ReadLine(), ci);
            x.C = double.Parse(Console.ReadLine(), ci);
            Console.WriteLine("Entre com as medidas do triângulo Y: ");
            y.A = double.Parse(Console.ReadLine(), ci);
            y.B = double.Parse(Console.ReadLine(), ci);
            y.C = double.Parse(Console.ReadLine(), ci);

            x.Area();
            y.Area();

            Console.WriteLine("Área de X = "+x.Area().ToString("F2", ci));
            Console.WriteLine("Área de Y = "+y.Area().ToString("F2", ci));

            if (x.Area() > y.Area()) {
                Console.WriteLine("Maior área: X");
            }
            else {
                Console.WriteLine("Maior área: Y");
            }
        }
    }
}