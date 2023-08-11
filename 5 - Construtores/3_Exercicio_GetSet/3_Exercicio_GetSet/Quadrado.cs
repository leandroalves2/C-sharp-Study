using System;
using System.Globalization;

namespace _3_Exercicio_GetSet {
    internal class Quadrado {

        CultureInfo ci = CultureInfo.InvariantCulture;

        //Base
        private double _basee;
        public double GetBase() {
            return this._basee;
        }
        public void SetBase(double basee) {
            if (basee >= 0) this._basee = basee;
            else this._basee = 0.00;
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
        public double AreaQuadrado() {
            return _basee * _altura;
        }
        // construtores
        public Quadrado() {
        }
        public Quadrado( double basee, double altura) {
            _basee = basee;
            _altura = altura;
        }

        //metodo
        public override string ToString() {
            return "A base é de: " + _basee.ToString("F2", ci) +
                ". A altura é de: " + _altura.ToString("F2", ci) +
                ". A area do quadrado é de: " + AreaQuadrado().ToString("F2", ci);
        }
    }
}
