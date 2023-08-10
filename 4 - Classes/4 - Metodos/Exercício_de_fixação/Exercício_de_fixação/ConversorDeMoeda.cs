using System;

namespace Exercício_de_fixação {
    internal class ConversorDeMoeda {

        public static double dolar;
        public static double valorCompra;

        public static double valorAPagar () {
            return (0.06 * (dolar * valorCompra)) + (dolar * valorCompra);
        }
    }
}
