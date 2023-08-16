using System;
using System.Globalization;

namespace Jogo_da_Forca {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("---------------------------- LEANDRO ------------------------------");

            Console.WriteLine("Bem vindo ao jogo da forca!");
            Console.WriteLine("Regras: Voce tem cinco chances para poder chutar letras até acertar " +
                "a palavra aleatória, cada erro de letra vai se montando o boneco na forca, a qualquer momento " +
                "voce pode churar a palavra, caso erre ou caso o boneco se complete, voce perde o jogo.");

            string[] PalavrasAleatorias = new string[10] {
        "sagaz", "mexer", "afeto", "plena", "ideia", "poder", "justo", "torpe", "lapso", "expor"
            };
  
            Random rand = new Random();
            int rand_num = rand.Next(0, 9);
            string palavra = PalavrasAleatorias[rand_num];

            char[] letraPalavra = new char[palavra.Length];
            for (int i = 0; i < palavra.Length; i++) {
                letraPalavra[i] = palavra[i];
            }
            char[] palavraOculta = new char[palavra.Length];
            for (int i = 0; i < palavra.Length; i++) {
                palavraOculta[i] = '_';
            }
            Console.WriteLine();
            Console.WriteLine("A palavra tem " + palavra.Length + " letras.");
            for (int i = 0; i < palavra.Length; i++) {
                Console.Write(palavraOculta[i] + "  ");
            }

            Console.WriteLine();
            string palpitePalavra = null;
            int cont = 0;
            int cont2 = 0;
            Console.WriteLine();

            while (palpitePalavra != palavra && cont < 5 && cont2 < 5) {

                

                Console.WriteLine();
                Console.Write("Digite uma letra: ");
                char palpiteLetra = char.Parse(Console.ReadLine());

                bool check = false;

                for (int i = 0; i < palavra.Length; i++) {
                    if (palpiteLetra == letraPalavra[i]) {
                        cont2 = cont2 + 1;
                        for (int j = 0; j < palavra.Length; j++) {
                            palavraOculta[i] = palpiteLetra;
                            if (palavraOculta[i] == palpiteLetra) {
                                check = true;
                            }
                        }
                    }
                }


                if (check == false) {
                    cont = cont + 1;
                }

                Console.WriteLine();
                for (int i = 0; i < palavra.Length; i++) {
                    Console.Write(palavraOculta[i] + "  ");
                }

                Console.WriteLine();
                Console.WriteLine("Você errou " + cont + " vezes, falta " + (5 - cont) + " tentativas");

                Console.WriteLine();
                Console.Write("Gostaria de tentar adivinhar (s/n)? ");
                char resp = char.Parse(Console.ReadLine());

                if (resp == 's' || resp == 'S') {
                    Console.Write("Qual a palavra? ");
                    palpitePalavra = Console.ReadLine();
                    if (resp == 's' || resp == 'S') {
                        Console.WriteLine();
                        Console.Write("ACERTOU ");
                    }
                    else {
                        Console.WriteLine();
                        Console.Write("ERROU!");
                        Console.Write("A palavra era: " + palavra);
                    }
                }

                if (cont >= 5) {
                    Console.WriteLine();
                    Console.Write("PERDEU!");
                    Console.Write("A palavra era: " + palavra);
                    Console.WriteLine();
                }                
            }
        }
    }
}
