using System;
using System.Globalization;

namespace _2_Exercicio_GetSet {
    internal class Program {
        static void Main(string[] args) {

            Pessoa p1 = new Pessoa();
            Pessoa p2 = new Pessoa();
            Pessoa p3 = new Pessoa();

            Console.WriteLine("Determine qual é a pessoa mais velha!");

            Console.WriteLine();
            Console.Write("Nome da 1 pessoa: ");
            string nome1 = Console.ReadLine();
            p1.SetNome(nome1);
            Console.Write("Idade da 1 pessoa: ");
            p1.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.Write("Nome da 2 pessoa: ");
            string nome2 = Console.ReadLine();
            p2.SetNome(nome2);
            Console.Write("Idade da 2 pessoa: ");
            p2.Idade = int.Parse(Console.ReadLine());


            Console.WriteLine();
            Console.Write("Nome da 3 pessoa: ");
            string nome3 = Console.ReadLine();
            p3.SetNome(nome3);
            Console.Write("Idade da 3 pessoa: ");
            p3.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine();
            if (p1.Idade > p2.Idade && p1.Idade > p3.Idade) {
                Console.WriteLine(p1.ExibirDados()); 
            }
            if (p2.Idade > p1.Idade && p2.Idade > p3.Idade) {
                Console.WriteLine(p2.ExibirDados());
            }
            if (p3.Idade > p1.Idade && p3.Idade > p2.Idade) {
                Console.WriteLine(p3.ExibirDados());
            }

        }
    }
}
