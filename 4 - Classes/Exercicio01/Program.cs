using System;
using System.Globalization;

namespace Exercicio01 {
    internal class Program {
        static void Main(string[] args) {

            CultureInfo ci = CultureInfo.InvariantCulture;

            Retangulo x = new Retangulo();

            Console.WriteLine("Entre a largura e altura do retangulo: ");
            x.A = double.Parse(Console.ReadLine(), ci);
            x.B = double.Parse(Console.ReadLine(), ci);
            
            Console.WriteLine("AREA = " + x.Area().ToString("F2", ci));
            Console.WriteLine("PERÍMETRO = " + x.Perimetro().ToString("F2", ci));
            Console.WriteLine("DIAGONAL  = " + x.Diagonal().ToString("F2", ci));
        }
    }
}
