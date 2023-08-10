using System;
using System.Globalization;

namespace prova {
    internal class Program {
        static void Main(string[] args) {

            CultureInfo ci = CultureInfo.InvariantCulture;

            int cod1, cod2, qtd1, qtd2;
            double valor1, valor2, total;

            Console.WriteLine("Peça 1");
            Console.Write("Digite o codigo: ");
            cod1 = int.Parse(Console.ReadLine());
            Console.Write("Digite a quantidade: ");
            qtd1 = int.Parse(Console.ReadLine());
            Console.Write("Digite o valor unitário: ");
            valor1 = double.Parse(Console.ReadLine(), ci);
            Console.WriteLine("");
            Console.WriteLine("Peça 2");
            Console.Write("Digite o codigo: ");
            cod2 = int.Parse(Console.ReadLine());
            Console.Write("Digite a quantidade: ");
            qtd2 = int.Parse(Console.ReadLine());
            Console.Write("Digite o valor unitário: ");
            valor2 = double.Parse(Console.ReadLine(), ci);
            Console.WriteLine("");

            total = (qtd1 * valor1) + (qtd2 * valor2);

            Console.WriteLine("VALOR A PAGAR: R$ " + total.ToString("F2", ci));

        }
    }
}
