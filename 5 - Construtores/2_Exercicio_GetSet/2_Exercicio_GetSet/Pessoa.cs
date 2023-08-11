using System;
using System.Globalization;

namespace _2_Exercicio_GetSet {
    internal class Pessoa {
        //nome
        private string _nome;
        public string GetNome() {
            return _nome;
        }
        public void SetNome(string nome) {
            _nome = nome;
        }

        //idade
        public int Idade;

        //construtr
        public Pessoa() {}
        public Pessoa(string nome, int idade) {
        
        }

        public string ExibirDados() {
            return "A pessoa mais velha é: " + _nome + ", com a idade de: " + Idade;
        }
    }
}
