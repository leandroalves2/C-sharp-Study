using System;
using System.Globalization;

namespace ExercicioFixacaoBanco {
    internal class ContaBancaria {

        CultureInfo ci = CultureInfo.InvariantCulture;

        //Atributos
        public int NumeroConta { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        //Construtores
        public ContaBancaria(int numeroConta, string titular) {
            NumeroConta = numeroConta;
            Titular = titular;
        }
        public ContaBancaria(int numeroConta, string titular, double depositoInicial) : this(numeroConta, titular)  {
            DepositoDeValor(depositoInicial);
        }

        //Metodos

        public void DepositoDeValor(double deposito) {
            Saldo = Saldo + deposito;
        }

        public void SaqueDeValor(double saque) {
            Saldo = Saldo - (saque + 5.00);
        }

        public override string ToString() {
            return "Conta " + NumeroConta + ", Titular: " + Titular + ", Saldo: $"
                + Saldo.ToString("F2", ci);
        }
    }
}
