using System;
using System.Globalization;

namespace ExercicioFixacaoBanco {
    internal class Program {
        static void Main(string[] args) {

            CultureInfo ci = CultureInfo.InvariantCulture;
            ContaBancaria dados;

            Console.Write("Entre o número da conta: ");
            int numeroConta = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string nomeTitular = Console.ReadLine();
            Console.Write("Haverá depósito inicial? (s/n): ");
            char depin = char.Parse(Console.ReadLine());

            if (depin == 's' || depin == 'S') {
                Console.Write("Entre o valor do depósito inicial: ");
                double valorInicial = double.Parse(Console.ReadLine(), ci);
                dados = new ContaBancaria(numeroConta, nomeTitular, valorInicial);
            }
            else {
                dados = new ContaBancaria(numeroConta, nomeTitular);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(dados);

            Console.WriteLine();
            Console.Write("Entre um valor de depósito: ");
            double valorDeposito = double.Parse(Console.ReadLine(), ci);
            dados.DepositoDeValor(valorDeposito);

            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(dados);

            Console.WriteLine();
            Console.Write("Entre um valor para saque: ");
            double valorSaque = double.Parse(Console.ReadLine(), ci);
            dados.SaqueDeValor(valorSaque);

            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(dados);

        }
    }
}
