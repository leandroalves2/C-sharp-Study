using System;

namespace _1_exemploSwitch {
    internal class Program {
        static void Main(string[] args) {

            Console.Write("Digite um número da semana: ");
            int x = int.Parse(Console.ReadLine());
            string dia;

            switch (x) {
                case 1:
                    dia = "Domingo";
                    break;
                case 2:
                    dia = "Segunda";
                    break;
                case 3:
                    dia = "Terça";
                    break;
                case 4:
                    dia = "Quarta";
                    break;
                case 5:
                    dia = "Quinta";
                    break;
                case 6:
                    dia = "Sexta";
                    break;
                case 7:
                    dia = "Sabado";
                    break;
                default:
                    dia = "Valor invalido";
                    break;
            }
            Console.WriteLine("dia: " + dia);




        }
    }
}
