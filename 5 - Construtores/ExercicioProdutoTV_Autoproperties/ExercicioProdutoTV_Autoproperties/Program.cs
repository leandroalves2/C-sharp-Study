using System;
using System.Globalization;

namespace ExercicioProdutoTV_Autoproperties {
    internal class Program {
        static void Main(string[] args) {

            CultureInfo ci = CultureInfo.InvariantCulture;
            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), ci);
            Console.Write("Quantidade no estoque: ");
            int quantidade = int.Parse(Console.ReadLine());

            Produto dados = new Produto(nome, preco, quantidade);
            

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + dados);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int quantidade2 = int.Parse(Console.ReadLine());
            dados.AdicionarProtudos(quantidade2);

            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + dados);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            quantidade2 = int.Parse(Console.ReadLine());
            dados.RemoveProtudos(quantidade2);

            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + dados);
        }
    }
}
