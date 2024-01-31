using System;

namespace _5___heranca_multipla.Entities
{
    internal class Scanner : Device, IScanner
    {

        public override void ProcessDoc(string doc)
        {
            Console.WriteLine("Scanner processing: " + doc);
        }

        public string Scan()
        {
            return "Scan sucess";
        }
    }
}