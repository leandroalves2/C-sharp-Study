using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_exemploVar {
    internal class Program {
        static void Main(string[] args) {

            // sem especificar o tipo de variavel
            Console.Write("Digite um número: ");
            var x = Console.ReadLine();
            Console.Write("Digite um número: ");
            var y = Console.ReadLine();
            var z = x + y;
            Console.WriteLine("A soma é: "+ z);

            // com o tipo de variavel ja iniciada
            Console.WriteLine();
            var x1 = 2;
            var y2 = 3;
            var z1 = x1 + y2;
            Console.WriteLine("A soma é: " + z1);
        }
    }
}
