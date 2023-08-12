using System;
using System.Globalization;

namespace _4_exercicioFixacao {
    internal class DadosPessoas {

        CultureInfo ci = CultureInfo.InvariantCulture;

        public string Nome;
        public int Idade;
        public double Altura;

        public DadosPessoas(string nome, int idade, double altura) {
            Nome = nome;
            Idade = idade;
            Altura = altura;

        }
    }
}
