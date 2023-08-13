using System;

namespace _4_exemploFuncoesStrings {
    internal class Program {
        static void Main(string[] args) {
            
            string original = "abcde FGHIJ ABC abc DEFG    ";
            Console.WriteLine("Origial: " + original);

            // Tudo maiusculo
            string upper = original.ToUpper();            
            Console.WriteLine("Tudo maiusculo: -" + upper);

            // Tudo minusculo
            string lower = original.ToLower();
            Console.WriteLine("Tudo maiusculo: -" + lower + "-");

            //Sem espaços antes e depois
            string trim = original.Trim();
            Console.WriteLine("Sem espaços: -" + trim +"-");

            // localiza na string em qual a primeira posicao esta a busca (primeira ocorrencia)
            int localiza1 = original.IndexOf("bc");
            Console.WriteLine("Voce procurou por 'bc' que esta na posição: -" + localiza1 + "-");

            // localiza na string em qual a ultima posicao esta a busca (ultima ocorrencia)
            int localiza2 = original.LastIndexOf("bc");
            Console.WriteLine("Voce procurou por 'bc' que esta na posição: -" + localiza2 + "-");

            // Como cortar a string a partir de uma posição
            string cort1 = original.Substring(3);
            Console.WriteLine("A partir da posição 3, a string fica: -" + cort1 + "-");

            // Como cortar a string a partir de uma posição e o maximo de caracter: (3) é a posição e (5) quantidade a se manter de caracter
            string cort2 = original.Substring(3, 5);
            Console.WriteLine("A partir da posição 3, a string fica: -" + cort2 + "-");

            // trocar letras (diferença de maiuscula de minuscula)
            string replace1 = original.Replace('a', 'x');
            Console.WriteLine("Trocando todaas as letrras 'a' por 'x': -" + replace1 + "-");

            // trocar string (diferença de maiuscula de minuscula)
            string replace2 = original.Replace("abc", "xy");
            Console.WriteLine("Trocando todaas as letrras 'abc' por 'xy': -" + replace2 + "-");

            // testar se a string é vazia ou nula
            bool void1 = string.IsNullOrEmpty(original);
            Console.WriteLine("A string é vazia ou nula? " + void1);

            // testar se a string é nula ou com espaços em branco
            bool void2 = string.IsNullOrWhiteSpace(original);
            Console.WriteLine("A string é nula ou apenas espaço branco? " + void2);
        }
    }
}
