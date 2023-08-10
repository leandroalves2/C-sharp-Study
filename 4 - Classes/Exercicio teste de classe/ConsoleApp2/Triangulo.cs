using System;
using System.Globalization;

namespace ConsoleApp2 {
    internal class Triangulo {

        CultureInfo ci = CultureInfo.InvariantCulture;


        public double Lado;

        public Triangulo(double lado) {
            Lado = lado;
        }

        public double Area() {
            return ((Lado * Lado) * Math.Sqrt(3)) / 4;
        }

        public double Perimetro() {
            return Lado * 3;
        }

        public override string ToString() {
            return "A área do triangulo equilatero é: " + Area().ToString("F2", ci) +
                ". Já o perimetro é: " + Perimetro().ToString("F2", ci);
        }


    }
}
