using System;

namespace _3___Repetitiva_Exercício_3._1 {
    internal class Program {
        static void Main(string[] args) {

            int senha = 2002;
            int x;

            Console.Write("Digite a senha: ");
            x = int.Parse(Console.ReadLine());

            while (x != senha) {
                Console.Write("Senha Invalida, tente novamente: ");
                x = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Acesso Permitido");
        }
    }
}
