using System;

namespace _6_exemplo_ref {
    internal class Program {
        static void Main(string[] args) {

            Console.Write("Digite um número: ");
            int a = int.Parse(Console.ReadLine());

            // sem referencia
            Console.WriteLine();
            Triple1(a);
            Console.WriteLine(a);

            // com ref
            Triple2(ref a);
            Console.WriteLine();
            Console.WriteLine(a);
        }

        public static void Triple1(int x) {
            x = x * 3;
        }
        public static void Triple2(ref int x) {
            x = x * 3;
        }        


    }

}
