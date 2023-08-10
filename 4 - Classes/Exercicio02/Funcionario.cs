using System;
using System.Globalization;

namespace Exercicio02
{
    public class Funcionario
    {
        CultureInfo ci = CultureInfo.InvariantCulture;
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido() {
            return SalarioBruto - Imposto;
        }

        public void AumentarSalario(double porcentagem) {
            double Porcentagem = (porcentagem / 100) * SalarioBruto;
            SalarioBruto = SalarioBruto + Porcentagem;
        }

        public override string ToString() {
            return Nome + ", $ " + SalarioLiquido().ToString("F2", ci);
        }
    }
}