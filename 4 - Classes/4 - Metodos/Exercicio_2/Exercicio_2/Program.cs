using System;
using System.Globalization;

namespace Exercicio_2 {
    internal class Program {
        static void Main(string[] args) {

            CultureInfo ci = CultureInfo.InvariantCulture;
            Funcionario dados = new Funcionario();

            Console.Write("Nome: ");
            dados.Nome = Console.ReadLine();
            Console.Write("Salário bruto: ");
            dados.Salario = double.Parse(Console.ReadLine(), ci);
            Console.Write("Imposto: ");
            dados.Imposto = double.Parse(Console.ReadLine(), ci);

            Console.WriteLine();
            Console.WriteLine("Funcionário: " + dados);

            Console.WriteLine();
            Console.Write("Digite a porcentagem para aumentar o salário: ");
            double perc = double.Parse(Console.ReadLine(), ci);
            dados.AumentarSalario(perc);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + dados);


        }
    }
}
