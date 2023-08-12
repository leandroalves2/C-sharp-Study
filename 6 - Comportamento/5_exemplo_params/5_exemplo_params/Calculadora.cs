using System;

namespace _5_exemplo_params {
    internal class Calculadora {

        public static int Soma(params int[] numeros) {
            int result = 0;
            for (int i = 0; i < numeros.Length; i++) { result = result + numeros[i]; }
            return result;
        }



    }
}
