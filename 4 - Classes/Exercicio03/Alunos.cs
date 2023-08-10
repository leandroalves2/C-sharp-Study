using System;
using System.Globalization;

namespace Exercicio03
{
    public class Alunos
    {
        CultureInfo ci = CultureInfo.InvariantCulture;
        public double N1, N2, N3;
        public string Nome;
   

        public double Soma(){
            return N1 + N2 + N3;
        }

        public override string ToString() {
                return "NOTA FINAL = " + Soma().ToString("F2", ci);
        }
    }
}   