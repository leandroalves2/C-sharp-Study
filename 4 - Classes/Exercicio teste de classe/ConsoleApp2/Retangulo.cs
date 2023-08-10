using System;
using System.Globalization;

namespace ConsoleApp2 {
    internal class Retangulo {

        CultureInfo ci = CultureInfo.InvariantCulture;

        public double Base, Altura;

        public Retangulo(double basee, double altura) {
            Base = basee;
            Altura = altura;
        }

        public double Area() {
            return Base * Altura;
        }

        public double Perimetro() {
            return 2 * (Base + Altura);
        }

        public override string ToString() {
            return "A área do retangulo é: " + Area().ToString("F2", ci) +
                ". Já o perimetro é: " + Perimetro().ToString("F2", ci);
        }

    }
}
