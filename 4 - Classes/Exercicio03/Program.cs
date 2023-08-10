using System;
using System.Globalization;

namespace Exercicio03 {
    class Program {         
        static void Main(string[] args) {

            Alunos dados = new Alunos();
            CultureInfo ci = CultureInfo.InvariantCulture;

            Console.Write("Nome do aluno: ");
            dados.Nome = Console.ReadLine();

            Console.WriteLine("Digite as três notas do aluno: ");
            dados.N1 = double.Parse(Console.ReadLine(), ci);
            dados.N2 = double.Parse(Console.ReadLine(), ci);
            dados.N3 = double.Parse(Console.ReadLine(), ci);

            dados.Soma();
            
            Console.WriteLine(dados);
            if (dados.Soma() >= 60.00) {
                Console.WriteLine("APROVADO");
            }
            else {
                Console.WriteLine("REPROVADO");
                double falta = 60.00 - dados.Soma();
                Console.WriteLine("FALTARAM "+ falta.ToString("F2", ci) +" PONTOS");
            }

        }
    }
}