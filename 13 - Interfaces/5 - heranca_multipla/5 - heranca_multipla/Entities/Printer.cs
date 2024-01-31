using System;

namespace _5___heranca_multipla.Entities
{
    internal class Printer : Device, IPrinter
    {
        public override void ProcessDoc(string doc)
        {
            Console.WriteLine("Printer processing: " + doc);
        }

        public void Print()
        {
            Console.WriteLine("Print sucess");
        }
    }
}
