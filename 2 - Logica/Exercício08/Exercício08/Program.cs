using System;
using System.Globalization;

namespace Exercício08 {
    internal class Program {
        static void Main(string[] args) {

            CultureInfo ci = CultureInfo.InvariantCulture;
            double  pag, resul, resul2, resul3, resul4, resul5;

            Console.WriteLine("Calculo de Imposto de Renda.");
            Console.WriteLine("");
            Console.Write("Digite a renda: ");
            double renda = double.Parse(Console.ReadLine(), ci);
            Console.WriteLine("");

            if (renda <= 2000.00) {
                Console.WriteLine("Insento.");
            }
            else if (renda > 2000.00 && renda <= 3000.00) {
                resul = renda - 2000.00;
                pag = resul * 0.08;
                Console.WriteLine("Valor: R$ {0}", pag.ToString("F2", ci));
            }
            else if (renda > 3000.00 && renda <= 4500.00) {
                resul = renda - 2000.00;
                resul2 = 1000 * 0.08;
                resul3 = renda - 3000;
                resul4 = resul3 * 0.18;
                pag = resul2 + resul4;
                Console.WriteLine("Valor: R$ {0}", pag.ToString("F2", ci));
            }
            else {
                resul = renda - 2000.00;
                resul2 = 1000 * 0.08;
                resul3 = 1500 * 0.18;
                resul4 = renda - 4500.00;
                resul5 = resul4 * 0.28;
                pag = resul2 + resul3 + resul5;
                Console.WriteLine("Valor: R$ {0}", pag.ToString("F2", ci));
            }

        }
    }
}
