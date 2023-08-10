using System;
using System.Globalization;

namespace Exercicio02 {
    class Program {
        static void Main(string[] args) {

            CultureInfo ci = CultureInfo.InvariantCulture;
            Funcionario dados = new Funcionario();

            Console.Write("Nome: ");
            dados.Nome = Console.ReadLine();
            Console.Write("Salário bruto: ");
            dados.SalarioBruto = double.Parse(Console.ReadLine(), ci);
            Console.Write("Imposto: ");
            dados.Imposto = double.Parse(Console.ReadLine(), ci);

            Console.WriteLine();
            Console.WriteLine("Funcionário: " + dados);

            Console.WriteLine();
            Console.Write("Digite a porcentagem para aumentar o salário: ");
            double porc = double.Parse(Console.ReadLine(), ci);
            dados.AumentarSalario(porc);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + dados);

        }
    }
}