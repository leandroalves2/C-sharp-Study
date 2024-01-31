using System;

namespace _5___heranca_multipla.Entities
{
    internal class ComboDevice : Device, IScanner, IPrinter
    {
        public override void ProcessDoc(string doc)
        {
            Console.WriteLine("Combo processing");
        }

        public void Print()
        {
            Console.WriteLine("Print sucess");
        }

        public string Scan()
        {
            return "Scan sucess";
        }

    }
}
