using System;
using System.Globalization;

namespace Exercicio_3 {
    internal class Program {
        static void Main(string[] args) {

            CultureInfo ci = CultureInfo.InvariantCulture;

            Aluno dados = new Aluno();

            Console.Write("Nome do aluno: ");
            dados.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno: ");
            dados.A = double.Parse(Console.ReadLine(), ci);
            dados.B = double.Parse(Console.ReadLine(), ci);
            dados.C = double.Parse(Console.ReadLine(), ci);

            Console.WriteLine("NOTA FINAL = " + dados.NotaFinal());
            Console.WriteLine(dados.Resultado());
            

        }
    }
}
