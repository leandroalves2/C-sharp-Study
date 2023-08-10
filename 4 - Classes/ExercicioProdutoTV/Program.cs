using System;
using System.Globalization;

namespace ExercicioProdutoTV {

    class Program {
        static void Main(string[] args) {
            CultureInfo ci = CultureInfo.InvariantCulture;
            Produto dados = new Produto();

            Console.WriteLine("Entre os dados do produto: ");
            Console.Write("Nome: ");
            dados.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            dados.Preco = double.Parse(Console.ReadLine(), ci);
            Console.Write("Quantidade no estoque: ");
            dados.Quantidade = int.Parse(Console.ReadLine());

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