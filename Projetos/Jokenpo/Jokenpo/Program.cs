using System;

namespace Jokenpo {
    internal class Program {
        static void Main(string[] args) {

            Random numAleatorio = new Random();           
            

            //1 = pedra; 2 = papel; 3 = tesoura;

            char resposta = 'S';

            while (resposta != 'N') {
                int valorInteiro = numAleatorio.Next(1, 3);
                Console.WriteLine("Digite o que quer jogaR: ");
                switch (Console.ReadLine()) {
                    case "pedra":
                        if (valorInteiro == 1) {
                            Console.WriteLine("EMPATOU");
                            Console.WriteLine("PC jogou pedra");
                            Console.WriteLine();
                        }
                        else if (valorInteiro == 2) {
                            Console.WriteLine("PERDEU");
                            Console.WriteLine("PC jogou papel");
                            Console.WriteLine();
                        }
                        else {
                            Console.WriteLine("GANHOU");
                            Console.WriteLine("PC jogou tesoura");
                            Console.WriteLine();
                        }
                        break;
                    case "papel":
                        if (valorInteiro == 1) {
                            Console.WriteLine("GANHOU");
                            Console.WriteLine("PC jogou pedra");
                            Console.WriteLine();
                        }
                        else if (valorInteiro == 2) {
                            Console.WriteLine("EMPATOU");
                            Console.WriteLine("PC jogou papel");
                            Console.WriteLine();
                        }
                        else {
                            Console.WriteLine("PERDEU");
                            Console.WriteLine("PC jogou tesoura");
                            Console.WriteLine();
                        }
                        break;
                    case "tesoura":
                        if (valorInteiro == 1) {
                            Console.WriteLine("PERDEU");
                            Console.WriteLine("PC jogou pedra");
                            Console.WriteLine();
                        }
                        else if (valorInteiro == 2) {
                            Console.WriteLine("GANHOU");
                            Console.WriteLine("PC jogou papel");
                            Console.WriteLine();
                        }
                        else {
                            Console.WriteLine("EMPATOU");
                            Console.WriteLine("PC jogou tesoura");
                            Console.WriteLine();

                        }
                        break;

                }
                Console.WriteLine("Quer continuar? S/N");
                resposta = char.Parse(Console.ReadLine());
                Console.WriteLine();
            }
        }
    }
}
