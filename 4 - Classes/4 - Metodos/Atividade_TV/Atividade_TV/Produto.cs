using System;
using System.Globalization;

namespace Atividade_TV {
    internal class Produto {

        CultureInfo ci = CultureInfo.InvariantCulture;

        public string Nome;
        public double Preco;
        public int Quantidade;

        public double Total() {
            return Preco * Quantidade;
        }

        public void Adicionar(int quantidade) {        
            Quantidade = quantidade + Quantidade;
        }

        public void Retirar(int quantidade) {
            Quantidade = Quantidade - quantidade;
        }

        public override string ToString() {
            return Nome +  ", $ "
                + Preco.ToString("F2", ci)+ ", "
                + Quantidade + " unidades, Total: $ "
                + Total().ToString("F2", ci);
        }

    }
}
