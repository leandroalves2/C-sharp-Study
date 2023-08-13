using System;

namespace _7_exemploDateTime_Operacoes {
    internal class Program {
        static void Main(string[] args) {

            DateTime d = new DateTime(2003, 02, 26, 11, 05, 30, 650);
            Console.WriteLine(d);

            // Adicionar horas, min, seg SEPARADOS
            DateTime d2 = d.AddHours(2);
            Console.WriteLine(d2);
            DateTime d3 = d2.AddMinutes(25);
            Console.WriteLine(d3);

            //Voce pode usar por exemplo para gerar o vencimento de um boleto.
            //Ex: boleto emitido HOJE com vencimento a 7 dias apos emissão
            Console.WriteLine();
            DateTime boleto = DateTime.Now;
            DateTime vencimento = boleto.AddDays(7);
            //APENAS UMA BRINCADEIRA PRA GERAR BOLETO EM DIA UTIL.
            string day = vencimento.DayOfWeek.ToString();
            Console.WriteLine(day);
            if (day == "Saturday") { vencimento = boleto.AddDays(9); }
            else if (day == "Sunday") { vencimento = boleto.AddDays(8); }   
            //formatação para visualização do boleto
            Console.WriteLine("Data de emissão do boleto: "+ boleto.ToShortDateString() 
                + ". Data de vencimento: " + vencimento.ToShortDateString());

            // Diferença entre datas
            Console.WriteLine();
            DateTime data1 = new DateTime(2003, 01, 26);
            Console.WriteLine(data1);
            DateTime data2 = new DateTime(2003, 01, 30);
            Console.WriteLine(data2);
            TimeSpan t = data2.Subtract(data1);
            Console.WriteLine(t);
            // neste caso ele apareceu "4.00:00:00", 4. = dias, e o resto é referente as horas.

        }
    }
}
