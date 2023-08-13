using System;

namespace _7_exemploDateTime_Operacoes {
    internal class Program {
        static void Main(string[] args) {

            DateTime data = new DateTime(2023, 02, 26, 10, 38, 15, 237);

            Console.WriteLine(data);
            Console.WriteLine();

            Console.WriteLine("1) Apenas a data: " + data.Date);
            Console.WriteLine("2) Apenas o dia: " + data.Day);
            Console.WriteLine("3) Dia da semana: " + data.DayOfWeek);
            Console.WriteLine("4) Dia do ano: " + data.DayOfYear);
            Console.WriteLine("5) Hora: " + data.Hour);
            Console.WriteLine("6) Tipo: " + data.Kind);
            Console.WriteLine("7) Milisegundos: " + data.Millisecond);
            Console.WriteLine("8) Minutos: " + data.Minute);
            Console.WriteLine("9) Mes: " + data.Month);
            Console.WriteLine("10) Segundos: + " + data.Second);
            Console.WriteLine("11) Ticks: " + data.Ticks);
            Console.WriteLine("12) Hora do dia: " + data.TimeOfDay);
            Console.WriteLine("13) Ano: " + data.Year);

            //Imprimir a data COMPLETA
            Console.WriteLine();
            Console.WriteLine(data.ToLongDateString());
            // O comando ToLongDateString() e seus derivados converte a data em string, por isso pode ser armazenada tbm em uma variavel string
            string s1 = data.ToLongDateString();
            Console.WriteLine(s1);

            //Imprimir a hora COMPLETA
            Console.WriteLine();
            Console.WriteLine(data.ToLongTimeString());
            string s2 = data.ToLongTimeString();
            Console.WriteLine(s2);

            //Imprimir a data RESUMIDA
            Console.WriteLine();
            Console.WriteLine(data.ToShortDateString());
            string s3 = data.ToShortDateString();
            Console.WriteLine(s3);

            //Imprimir a hora RESUMIDA (sem os segundos, apenas horas e minutos)
            Console.WriteLine();
            Console.WriteLine(data.ToShortTimeString());
            string s4 = data.ToShortTimeString();
            Console.WriteLine(s4);

            // Chamando apenas o ToString() ele imprimi os dados padroes com data e hora.
            Console.WriteLine();
            Console.WriteLine(data.ToString());
            string s5 = data.ToString();
            Console.WriteLine(s5);


            // Mascaras de formatação
            Console.WriteLine();
            string s6 = data.ToString("yyyy-MM-dd HH:mm:ss");
            Console.WriteLine(s6);
            string s7 = data.ToString("dd-MM-yyyy HH:mm:ss.fff");
            Console.WriteLine(s7);


        }
    }
}
