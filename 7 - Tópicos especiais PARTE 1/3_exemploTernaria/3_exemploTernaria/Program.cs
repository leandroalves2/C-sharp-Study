using System;
using System.Globalization;

namespace _3_exemploTernaria {
    internal class Program {
        static void Main(string[] args) {

            CultureInfo ci = CultureInfo.InvariantCulture;

            // com IF/ELSE
            Console.Write("Digite o preço: ");
            double preco = double.Parse(Console.ReadLine(), ci);
            double desconto;
            if (preco < 20) {
                desconto = preco * 0.1;
            }
            else {
                desconto = preco * 0.05;
            }
            double valor = preco - desconto;
            Console.WriteLine("O desconto foi de: " + desconto.ToString("F2", ci) + ".");
            Console.WriteLine("O novo valor é de: " + valor.ToString("F2", ci) + "."); ;

            // com TERNARIA
            Console.WriteLine();
            Console.Write("Digite o preço: ");
            preco = double.Parse(Console.ReadLine(), ci);
            desconto = (preco < 20) ? preco * 0.1 : desconto = preco * 0.05;
            valor = preco - desconto;
            Console.WriteLine("O desconto foi de: " + desconto.ToString("F2", ci) + ".");
            Console.WriteLine("O novo valor é de: " + valor.ToString("F2", ci) + "."); ;
        }
    }
}
