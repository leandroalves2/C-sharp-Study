using System;
using System.Globalization;

namespace _1_Exercicio_GetSet {
    internal class Program {
        static void Main(string[] args) {

            CultureInfo ci = CultureInfo.InvariantCulture;

            Pessoa p = new Pessoa();

            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            p.SetNome(nome);

            Console.Write("Ano de nascimento: ");
            int nascimento = int.Parse(Console.ReadLine());
            p.SetNascimento(nascimento);

            Console.Write("Altura: ");
            double altura = double.Parse(Console.ReadLine(), ci);
            p.SetAltura(altura);

            Console.WriteLine();
            Console.WriteLine(p);


        }
    }
}
