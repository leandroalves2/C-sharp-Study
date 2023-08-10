using System;

namespace _3___Repetitiva_Exercício_3._2 {
    internal class Program {
        static void Main(string[] args) {

            int cont1 = 0;
            int cont2 = 0;

            Console.Write("Quantos números serão digitados? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++) {
                Console.Write("Digite um número: ");
                int x = int.Parse(Console.ReadLine());
                if (x >= 10 && x <= 20) {
                    cont1 = cont1 + 1;
                }
                else {
                    cont2 = cont2 + 1;
                }
            }
            Console.WriteLine("Valores dentro: "+ cont1);
            Console.WriteLine("Valores fora: "+ cont2);
        }
    }
}
