using System;
using System.Globalization;

namespace Problema_exemplo_circunferência {
    internal class Circulo {

        CultureInfo ci = CultureInfo.InvariantCulture;

        public static double Pi = 3.14;

        public static double Area(double r) {
            return 2.0 * Pi * r;        
        }

        public static double Volume(double r) {
            return 4.0 / 3.0 * Pi * r * r * r;
        }

    }
}
