using System;
using System.Globalization;

namespace _8_exercicioFixacao {
    internal class Dados {

        public int Id { get; set; }
        public string Nome { get; set; }
        public double Salario { get; private set; }

        CultureInfo ci = CultureInfo.InvariantCulture;

        public Dados(int id, string nome, double salario) {
            Id = id;
            Nome = nome;
            Salario = salario;
        }

        public void AumentoSalario(double porcent) {
            double result = (porcent * Salario) / 100;
            Salario = Salario + result;
        }

        public override string ToString() {
            return Id + ", " + Nome + ", " + Salario.ToString("F2", ci);
        }

    }
}
