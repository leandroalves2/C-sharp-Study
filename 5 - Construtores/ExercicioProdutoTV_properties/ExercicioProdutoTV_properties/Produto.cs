using System;
using System.Globalization;

namespace ExercicioProdutoTV_properties {
    internal class Produto {

        CultureInfo ci = CultureInfo.InvariantCulture;

        //Nome
        private string _nome;
        public string Nome {
            get { return _nome; }
            set {
                if (_nome != null && value.Length > 1) {
                    _nome = value;
                }
            }

        }
        //Quantidade
        private int _quantidade;

        public int Quantidade {
            get { return _quantidade; }
            set { _quantidade = value; }
        }

        //Preço
        private double _preco;
        public double Preco {
            get { return _preco; }
            set { _preco = value; }
        }

        //Contrutores

        public Produto(string nome, int quantidade, double preco) {
            _nome = nome;
            _quantidade = quantidade;
            _preco = preco;
        }

        //Metodos
        public double TotalEmEstoque() {
            return _quantidade * _preco;
        }
        public void AdicionarProtudos(int quantidade) {
            _quantidade = _quantidade + quantidade;
        }
        public void RemoveProtudos(int quantidade) {
            _quantidade = _quantidade - quantidade;
        }

        public override string ToString() {
            return _nome + ", $ " + _preco.ToString("F2", ci) + ", " + _quantidade
                + " unidades, Total: $ " + TotalEmEstoque().ToString("F2", ci);
        }

    }   
}
