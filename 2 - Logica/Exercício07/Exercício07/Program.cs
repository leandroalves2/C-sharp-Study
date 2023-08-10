using System;

namespace Exercício07 {
    internal class Program {
        static void Main(string[] args) {

            Console.Write("Digite a quantidade de linhas: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++) {
                int quad = i * i;
                int cub = i * i * i;
                Console.WriteLine("{0}, {1}, {2}", i, quad, cub);
                
            }
        }
    }
}
