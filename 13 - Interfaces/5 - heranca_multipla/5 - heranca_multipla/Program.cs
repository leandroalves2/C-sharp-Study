using _5___heranca_multipla.Entities;
using System;

namespace _5___heranca_multipla
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Printer p = new Printer();
            p.ProcessDoc("My email");
            p.Print();

            Console.WriteLine();
            Scanner s = new Scanner();
            s.ProcessDoc("My Letter");
            Console.WriteLine(s.Scan());

            Console.WriteLine();
            ComboDevice cb = new ComboDevice();
            cb.ProcessDoc("My email and letter");
            cb.Print();
            Console.WriteLine(cb.Scan());

        }
    }
}
