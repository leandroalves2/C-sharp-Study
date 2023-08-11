using System;
using System.Globalization;

namespace ExercicioProdutoTV_Autoproperties {
    internal class Produto {

        CultureInfo ci = CultureInfo.InvariantCulture;

        //Atributos
        private string _nome;
        public int Quantidade { get; private set; }
        public double Preco { get; private set; }

        //Contrutores
        public Produto(string nome, double preco, int quantidade) {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        //Propriedades
        public string Nome {
            get { return _nome; }
            set {
                if (value != null && value.Length > 1) {
                    _nome = value;
                }
            }

        }      
        
        //Metodos
        public double TotalEmEstoque() {
            return Quantidade * Preco;
        }
        public void AdicionarProtudos(int quantidade) {
            Quantidade = Quantidade + quantidade;
        }
        public void RemoveProtudos(int quantidade) {
            Quantidade = Quantidade - quantidade;
        }

        public override string ToString() {
            return Nome + ", $ " + Preco.ToString("F2", ci) + ", " + Quantidade
                + " unidades, Total: $ " + TotalEmEstoque().ToString("F2", ci);
        }

    }
}
