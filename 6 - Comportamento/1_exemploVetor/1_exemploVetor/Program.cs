using System;
using System.Globalization;

namespace _1_exemploVetor {
    internal class Program {
        static void Main(string[] args) {

            CultureInfo ci = CultureInfo.InvariantCulture;            

            Console.Write("A altura de quantas pessoas serão registradas? ");
            int quant = int.Parse(Console.ReadLine());

            double[] vet = new double[quant];
            double soma = 0.00;

            Console.WriteLine();
            for (int i = 0; i < quant; i++) {
                Console.Write("Digite a " + (i+1) + " altura: ");
                vet[i] = double.Parse(Console.ReadLine(), ci);
                soma = soma + vet[i];
            }
            double media = soma / quant;

            Console.WriteLine();
            Console.WriteLine("A media é de: " + media.ToString("F2", ci));
            Console.WriteLine();

        }
    }
}
