using System;
using System.Globalization;


namespace Exercicio_3 {
    internal class Aluno {

        CultureInfo ci = CultureInfo.InvariantCulture;

        public string Nome;
        public double A;
        public double B;
        public double C;

        public double NotaFinal() {
            return A + B + C;        
        }

        public string Resultado() {
            if (NotaFinal() > 60.00) {
                return "APROVADO";
            }
            else {
                double falta = 60.00 - NotaFinal();
                return "REPROVADO, FALTARAM: " + falta.ToString("F2", ci) + " PONTOS.";
            }
        
        }
        


    }
}
