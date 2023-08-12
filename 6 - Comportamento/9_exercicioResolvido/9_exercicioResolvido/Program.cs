using System;

namespace _9_exercicioResolvido {
    internal class Program {
        static void Main(string[] args) {

            Console.Write("Qual a dimenção da matriz? ");
            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[n,n];

            Console.WriteLine("Digite os numeros da matriz: ");
            for (int i  = 0; i< n; i++) {
                for (int j = 0; j < n; j++) {
                    Console.Write("[{0}, {1}]: ", i, j);
                    mat[i, j] = int.Parse(Console.ReadLine());
                }
            }

            int cont = 0;
            Console.WriteLine();
            Console.WriteLine("Main diagonal: ");
            for (int i = 0; i < n; i++) {
                for (int j = 0; j < n; j++) {
                    if (i == j) {
                        Console.Write(mat[i, j] + "  ");
                    }
                    if (mat[i,j] < 0) {
                        cont = cont + 1;
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("Negative numbers = " + cont);



        }
    }
}
