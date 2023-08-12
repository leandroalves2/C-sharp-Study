using System;

namespace _3_exercicioFixacao {
    internal class Program {
        static void Main(string[] args) {

            Quartos[] quartos = new Quartos[10];

            Console.Write("Quantos quartos serão alugados? ");
            int quantosAlugar = int.Parse(Console.ReadLine());

            for (int i = 0; i < quantosAlugar; i++) {

                Console.WriteLine();
                Console.WriteLine("Aluguel #{0}:", (i + 1));
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());

                quartos[quarto] = new Quartos(nome, email);


                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("Quartos ocupados:");
          
            for (int i = 0; i < quartos.Length; i++) {
                if (quartos[i] != null) {
                        Console.WriteLine(i + ": " + quartos[i]);
                }
                
            }
        }
    }
}
