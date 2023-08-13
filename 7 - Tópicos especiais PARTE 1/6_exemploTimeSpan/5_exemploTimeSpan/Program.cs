using System;

namespace _5_exemploTimeSpan {
    internal class Program {
        static void Main(string[] args) {

            //contrutor vazio
            TimeSpan t1 = new TimeSpan();
            Console.WriteLine(t1);

            // informado a hora, min e seg
            TimeSpan t2 = new TimeSpan(1, 30, 0);
            Console.WriteLine(t2);

            //informando a quantidade de ticks
            TimeSpan t3 = new TimeSpan(900000000L);
            Console.WriteLine(t3);

            //informando dia antes da hora
            TimeSpan t4 = new TimeSpan(2, 5, 11, 21);
            Console.WriteLine(t4);

            // informando dia, hora, min, seg e milisegundo
            TimeSpan t5 = new TimeSpan(5, 2, 15, 30, 321);
            Console.WriteLine(t5);

            //Conta quanto tempo passou naquele intervalo de dias. ex: 1 dias e meio (1.5)
            TimeSpan t6 = TimeSpan.FromDays(1.5);
            Console.WriteLine(t6);

            //Conta o tempo informado. ex: 1.5 = 1 horas e meia
            TimeSpan t7 = TimeSpan.FromHours(1.5);
            Console.WriteLine(t7);

            //Conta o tempo informado. ex: 1.5 = 1 min e meio
            TimeSpan t8 = TimeSpan.FromMinutes(1.5);
            Console.WriteLine(t8);

            //Conta o tempo informado. ex: 1.5 = 1 seg e meio
            TimeSpan t9 = TimeSpan.FromSeconds(1.5);
            Console.WriteLine(t9);

            //Conta o tempo informado. ex: 1.5 = 1 milisegundo e os ticks
            TimeSpan t10 = TimeSpan.FromMilliseconds(1);
            Console.WriteLine(t10);

            //Conta o tempo baseado nos ticks informados
            TimeSpan t11 = TimeSpan.FromTicks(900000000L);
            Console.WriteLine(t11);
        }
    }
}
