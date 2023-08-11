using System;
using System.Globalization;

namespace _4_Exercicio_GetSet {
    internal class Program {
        static void Main(string[] args) {

            CultureInfo ci = CultureInfo.InvariantCulture;

            Console.WriteLine("Digite seu peso: ");
            double peso = double.Parse(Console.ReadLine(), ci);
            Console.WriteLine("Digite sua altura: ");
            double altura = double.Parse(Console.ReadLine(), ci);

            Pessoa dados = new Pessoa();            
            dados.SetPeso(peso);
            dados.SetAltura(altura);

            dados.IMC();

            Console.WriteLine();
            dados.RetornoImc();
            Console.WriteLine();
        }
    }
}
