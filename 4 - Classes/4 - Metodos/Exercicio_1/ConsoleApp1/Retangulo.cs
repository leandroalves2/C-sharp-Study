using System;
using System.Globalization;

namespace ConsoleApp1 {
    internal class Retangulo {

        CultureInfo ci = CultureInfo.InvariantCulture;

        public double A;
        public double B;

        public double Area() {
            return A * B;       
        }

        public double Perimetro() {
            return 2 * (A * B);            
        }

        public double Diagonal() {
            return Math.Sqrt(A * A + B * B);
        }


    }
}
