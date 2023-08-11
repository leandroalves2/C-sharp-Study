using System;
using System.Globalization;

namespace _3_Exercicio_GetSet {
    internal class Retangulo {

        CultureInfo ci = CultureInfo.InvariantCulture;

        //Base
        private double _base;
        public double GetBase() {
            return this._base;
        }
        public void SetBase(double basee) {
            if (basee >= 0) this._base = basee;
            else this._base = 0.00;

        }

        //Altura
        private double _altura;
        public double GetAltura() {
            return this._altura;
        }
        public void SetAltura(double altura) {
            if (altura >= 0) this._altura = altura;
            else this._altura = 0.00;
        }
        
        //Area
        public double AreaRetangulo() {
            return _base * _altura;
        }

        // construtores
        public Retangulo() {
        }
        public Retangulo(double basee, double altura) {
            _base = basee;
            _altura = altura;
        }

        //Metodo
        public override string ToString() {
            return "A base é de: " + _base.ToString("F2", ci) +
                ". A altura é de: " + _altura.ToString("F2", ci) +
                ". A area do retangulo é de: " + AreaRetangulo().ToString("F2", ci);
        }
    }
}
