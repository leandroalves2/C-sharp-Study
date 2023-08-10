using System;
using System.Globalization;
namespace ConsoleApp2 {
    internal class Quadrado {

        CultureInfo ci = CultureInfo.InvariantCulture;
        public double Lado;

        public Quadrado(double lado) {
            Lado = lado;        
        }

        public double Area() {
            return Lado * Lado;
        }

        public double Perimetro() {
            return 4 * Lado;
        }

        public override string ToString() {
            return "A área do quadrado é: " + Area().ToString("F2", ci) +
                ". Já o perimetro é: " + Perimetro().ToString("F2", ci);
        }


    }
}
