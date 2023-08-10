using System;
using System.Globalization;

namespace ConsoleApp1 {
    internal class Program {
        static void Main(string[] args) {

            CultureInfo ci = CultureInfo.InvariantCulture;

            Console.WriteLine("Entre os dados do produto: ");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), ci);
            Console.Write("Quantidade no estoque: ");
            int quantidade = int.Parse(Console.ReadLine());

            Produto dados = new Produto(nome, preco);

            Console.WriteLine();
            Console.WriteLine(dados);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int qtd = int.Parse(Console.ReadLine());
            dados.AdicionarProdutos(qtd);

            Console.WriteLine();
            Console.WriteLine(dados);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            qtd = int.Parse(Console.ReadLine());
            dados.RemoverProdutos(qtd);

            Console.WriteLine();
            Console.WriteLine(dados);

        }
    }
}
