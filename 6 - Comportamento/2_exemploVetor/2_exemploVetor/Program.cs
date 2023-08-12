using System;
using System.Globalization;

namespace _2_exemploVetor {
    internal class Program {
        static void Main(string[] args) {

            CultureInfo ci = CultureInfo.InvariantCulture;

            Console.Write("Quantos produtos serão digitados? ");
            int n = int.Parse(Console.ReadLine());

            double soma = 0.00;
            Produto[] vet = new Produto[n];

            Console.WriteLine();
            for (int i = 0; i < n; i++) {
                Console.Write("Qual nome do protudo? ");
                string nome = Console.ReadLine();
                Console.Write("Qual preço do protudo? ");
                double preco = double.Parse(Console.ReadLine(), ci);
                 vet[i] = new Produto(nome, preco);
                soma = soma + vet[i].Preco;

            }
            double media = soma / n;

            Console.WriteLine(); 
            Console.WriteLine("O preço medio dos produtos é: " + media.ToString("F2", ci));

            Console.WriteLine();
        }
    }
}
