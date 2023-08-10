using System;
using System.Globalization;

namespace ConsoleApp2 {
    internal class Program {
        static void Main(string[] args) {

            Console.Write("Voce quer calcular Triangulo, Retangulo ou Quadrado? ");
            string resposta = Console.ReadLine();


            int novo = 4;
            while (novo == 4) {
                if (resposta == "Triangulo" || resposta == "triangulo") {
                    novo = 1;
                }
                else if (resposta == "Retangulo" || resposta == "retangulo") {
                    novo = 2;
                }
                else if (resposta == "Quadrado" || resposta == "quadrado") {
                    novo = 3;
                }
                else {
                    Console.WriteLine("Valor invalido");
                    novo = 4;
                    Console.Write("Voce quer calcular Triangulo, Retangulo ou Quadrado? ");
                    resposta = Console.ReadLine();
                }
            }

            switch (novo) {
                case 1:
                    Console.WriteLine("Digite o lado do Triangulo equilatero: ");
                    double lado = double.Parse(Console.ReadLine());

                    Triangulo dados = new Triangulo(lado);

                    dados.Area();
                    dados.Perimetro();
                    Console.WriteLine();
                    Console.WriteLine(dados);

                    break;

                case 2:

                    Console.WriteLine("Digite a base e altura do Retangulo: ");
                    double basee = double.Parse(Console.ReadLine());
                    double altura = double.Parse(Console.ReadLine());

                    Retangulo dados2 = new Retangulo(basee, altura);

                    dados2.Area();
                    dados2.Perimetro();
                    Console.WriteLine();
                    Console.WriteLine(dados2);

                    break;

                case 3:

                    Console.WriteLine("Digite o lado do Quadrado: ");
                    lado = double.Parse(Console.ReadLine());

                    Quadrado dados3 = new Quadrado(lado);

                    dados3.Area();
                    dados3.Perimetro();
                    Console.WriteLine();
                    Console.WriteLine(dados3);

                    break;

            }
        }
    }
}
