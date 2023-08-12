using System;

namespace _6_exemplo_out {
    internal class Program {
        static void Main(string[] args) {

            Console.Write("Digite um numero: ");
            int a = int.Parse(Console.ReadLine());
            int saida;
            triple(a, out saida);

            Console.WriteLine();
            Console.WriteLine(a);
            Console.WriteLine(saida);


        }

        public static void triple(int origin, out int result) {
            result = origin * 3;


        }

    }
}
