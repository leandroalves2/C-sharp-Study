using System;
using System.Globalization;

namespace ConsoleApp1 {
    internal class Produto {

        CultureInfo ci = CultureInfo.InvariantCulture;
        public string Nome;
        public double Preco;
        public int Quantidade;

        public Produto(string nome, double preco, int quantidade) {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public Produto(string nome, double preco) {
            Nome = nome;
            Preco = preco;
            Quantidade = 45;
        }

        public double ValorTotalEmEstoque() {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int quantidade) {
            Quantidade = Quantidade + quantidade;
        }

        public void RemoverProdutos(int quantidade) {
            Quantidade = Quantidade - quantidade;
        }

        public override string ToString() {
            return "Dados do produto: " + Nome + ", $ " + Preco + ", " + Quantidade
            + " unidades, Total: $ " + ValorTotalEmEstoque().ToString("F2", ci);
        }



    }
}
