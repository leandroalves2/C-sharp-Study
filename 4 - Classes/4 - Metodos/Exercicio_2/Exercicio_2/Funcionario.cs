using System;
using System.Globalization;

namespace Exercicio_2 {
    internal class Funcionario {

        CultureInfo ci = CultureInfo.InvariantCulture;

        public string Nome;
        public double Salario;
        public double Imposto;

        public double SalarioLiquido() {
            return Salario - Imposto;
        }

        public void AumentarSalario(double porcentagem) {
            double Porcentagem = (porcentagem / 100) * Salario;
            Salario = Salario + Porcentagem;
        }

        public override string ToString() {
            return Nome + ", $ " + SalarioLiquido().ToString("F2", ci);
        }


    }
}
