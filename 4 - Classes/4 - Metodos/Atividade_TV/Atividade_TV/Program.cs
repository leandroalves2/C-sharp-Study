using System;
using System.Globalization;

namespace Atividade_TV {
    internal class Program {
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

            Console.WriteLine("Dados do produto: " + dados);

            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            dados.Adicionar(qte);

            Console.WriteLine("Dados do produto: " + dados);

            Console.Write("Digite o número de produtos a ser removido ao estoque: ");
            qte = int.Parse(Console.ReadLine());
            dados.Retirar(qte);

            Console.WriteLine("Dados do produto: " + dados);

        }
    }
}
