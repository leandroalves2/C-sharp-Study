using System;
using System.Globalization;


namespace _4_exercicioFixacao {
    internal class Program {
        static void Main(string[] args) {

            CultureInfo ci = CultureInfo.InvariantCulture;
            double somaAltura = 0.00 ;
            int somaIdade = 0;

            Console.Write("Quantas pessoas serão cadastradas? ");
            int n = int.Parse(Console.ReadLine());

            DadosPessoas[] dadosPessoas = new DadosPessoas[n];

            for (int i = 0; i < n; i++) {
                Console.Write("Digite o Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Digite a idade: ");
                int idade = int.Parse(Console.ReadLine());
                Console.Write("Digite a altura: ");
                double altura = double.Parse(Console.ReadLine(), ci);

                dadosPessoas[i] = new DadosPessoas(nome, idade, altura);
                somaAltura = somaAltura + dadosPessoas[i].Altura;
                if (idade < 16) {
                    somaIdade = somaIdade + 1;
                }

            }
            Console.WriteLine();
            Console.WriteLine("somaIdade =" + somaIdade);
            Console.WriteLine();

            double mediaAltura = somaAltura / n;
            double perc = (somaIdade / n) * 100.00;

            Console.WriteLine();
            Console.WriteLine("Altura média: " + mediaAltura.ToString("F2", ci));
            Console.WriteLine("Pessoas com medos de 16 anos: " + perc.ToString("F2", ci));
        }
    }
}
