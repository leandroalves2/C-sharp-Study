using System;
using System.Globalization;

namespace _3_Exercicio_GetSet {
    internal class Program {
        static void Main(string[] args) {

            CultureInfo ci = CultureInfo.InvariantCulture;

            Console.Write("Você quer calcular a área do quadrado ou retangulo? ");
            string resposta = Console.ReadLine();

            if (resposta == "quadrado" || resposta == "Quadrado") {
                Console.WriteLine("Digite a base e altura do quadrado: ");
                double basee = double.Parse(Console.ReadLine(), ci);
                double altura = double.Parse(Console.ReadLine(), ci);

                Quadrado dados = new Quadrado();
                dados.SetBase(basee);
                dados.SetAltura(altura);

                dados.AreaQuadrado();

                Console.WriteLine();
                Console.WriteLine(dados);
            }

            if (resposta == "retangulo" || resposta == "Retangulo") {
                Console.WriteLine("Digite a base e altura do retangulo: ");
                double basee = double.Parse(Console.ReadLine(), ci);
                double altura = double.Parse(Console.ReadLine(), ci);

                Retangulo dados = new Retangulo();
                dados.SetBase(basee);
                dados.SetAltura(altura);                

                dados.AreaRetangulo();

                Console.WriteLine();
                Console.WriteLine(dados);
            }

            else {
                Console.WriteLine();
                Console.WriteLine("Valor incorreto");
            }
        }
    }
}
