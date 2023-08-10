using System;
using System.Globalization;

namespace _2___Condicional_Exercício_2._1 {
    internal class Program {
        static void Main(string[] args) {
            
            CultureInfo ci = CultureInfo.InvariantCulture;
            int cod, qtd;
            double total;

            Console.Write("Digite o codigo do produto: ");
            cod = int.Parse(Console.ReadLine());
            Console.Write("Digite a quantidade do produto: ");
            qtd = int.Parse(Console.ReadLine(), ci);

            if (cod == 1) {
                total = qtd * 4.00;
                Console.WriteLine("Total: R$ " + total.ToString("F2", ci));
            }
            else if (cod == 2) {
                total = qtd * 4.50;
                Console.WriteLine("Total: R$ " + total.ToString("F2", ci));
            }
            else if (cod == 3) {
                total = qtd * 5.00;
                Console.WriteLine("Total: R$ " + total.ToString("F2", ci));
            }
            else if (cod == 4) {
                total = qtd * 2.00;
                Console.WriteLine("Total: R$ " + total.ToString("F2", ci));
            }
            else if (cod == 5) {
                total = qtd * 1.50;
                Console.WriteLine("Total: R$ " + total.ToString("F2", ci));
            }
            else {
                Console.WriteLine("Codigo Invalido");
            }
        }
    }
}
