using System;
using System.Globalization;

namespace ExercicioProdutoTV
{
    public class Produto
    {
        CultureInfo ci = CultureInfo.InvariantCulture;
        public string Nome;
        public double Preco;
        public int Quantidade;

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
            return "Dados do produto: " + Nome + ", $ " + Preco + ", "+ Quantidade 
            + " unidades, Total: $ " + ValorTotalEmEstoque().ToString("F2", ci);
        }
        
        
    }
}