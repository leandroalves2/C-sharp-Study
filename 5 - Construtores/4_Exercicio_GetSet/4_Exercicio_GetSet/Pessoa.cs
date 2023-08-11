using System;
using System.Globalization;

namespace _4_Exercicio_GetSet {
    internal class Pessoa {

        CultureInfo ci = CultureInfo.InvariantCulture;

        //Peso
        private double _peso;
        public double GetPeso() {
            return this._peso;
        }
        public void SetPeso(double peso) {
            this._peso = peso;
        }

        //Altura
        private double _altura;
        public double GetAltura() {
            return this._altura;
        }
        public void SetAltura(double altura) {
            this._altura = altura;
        }

        //metodo
        public double IMC() {
            return this._peso / (this._altura * this._altura);
        }

        public void RetornoImc() {
            if (IMC() < 18.5) { Console.WriteLine("IMC de "+IMC().ToString("F2", ci)  + " - Abaixo do peso"); }
            if (IMC() >= 18.5 && IMC() < 25) { Console.WriteLine("IMC de " + IMC().ToString("F2", ci) + " - Peso normal"); }
            if (IMC() >= 25 && IMC() < 30) { Console.WriteLine("IMC de " + IMC().ToString("F2", ci) + " - Acima do peso"); }
            if (IMC() >= 30 && IMC() < 35) { Console.WriteLine("IMC de " + IMC().ToString("F2", ci) + " - Obesidade I"); }
            if (IMC() >= 35 && IMC() < 40) { Console.WriteLine("IMC de " + IMC().ToString("F2", ci) + " - Obesidade II"); }
            if (IMC() >= 40) { Console.WriteLine("IMC de " + IMC().ToString("F2", ci) + " - Obesidade III"); }
        }
    }
}