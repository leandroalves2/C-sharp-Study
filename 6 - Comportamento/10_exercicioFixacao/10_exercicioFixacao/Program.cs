using System;

namespace _10_exercicioFixacao {
    internal class Program {
        static void Main(string[] args) {

            Console.Write("Digite a quantidade de linhas da matriz: ");
            int m = int.Parse(Console.ReadLine());
            Console.Write("Digite a quantidade de colunas da matriz: ");
            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[m, n];

            for (int i = 0; i < m; i++) {
                for (int j = 0; j < n; j++) {
                    Console.Write("[{0},{1}]: ", i, j);
                    mat[i,j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine();
            Console.Write("Digite um número: ");
            int numb = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++) {
                for (int j = 0; j < n; j++) {
                    if (mat[i, j] == numb) {
                        Console.WriteLine("Position: " + i +"," + j);
                        if (j > 0) { 
                            Console.WriteLine("Esquerda: " + mat[i, j-1]);
                        }
                        if (i > 0) {
                            Console.WriteLine("Direita: " + mat[i - 1, j]);
                        }
                        if (j < n - 1) {
                            Console.WriteLine("Cima: " + mat[i, j + 1]);
                        }
                        if (i < m - 1) {
                            Console.WriteLine("Baixo: " + mat[i + 1, j]);
                        }
                        Console.WriteLine();

                    }
                }
            }


        }
    }
}
