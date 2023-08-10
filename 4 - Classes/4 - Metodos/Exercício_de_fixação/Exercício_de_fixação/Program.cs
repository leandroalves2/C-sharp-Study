using System;
using System.Globalization;

namespace Exercício_de_fixação {
    internal class Program {
        static void Main(string[] args) {

            CultureInfo ci = CultureInfo.InvariantCulture;

            Console.Write("Qual é a cotação do dólar? ");
            ConversorDeMoeda.dolar = double.Parse(Console.ReadLine(), ci);
            Console.Write("Quantos dólares você vai comprar? ");
            ConversorDeMoeda.valorCompra = double.Parse(Console.ReadLine(), ci);

            Console.WriteLine();
            Console.WriteLine("Valor a ser pago em reais = " + ConversorDeMoeda.valorAPagar().ToString("F2", ci));


        }
    }
}
