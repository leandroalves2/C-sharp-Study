using _4___Heranca_e_Interface.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4___Heranca_e_Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle cc = new Circle(2.0, Enuns.Colors.Black);
            Rectangle rec = new Rectangle(3.5, 4.2);

            Console.WriteLine(cc);
            Console.WriteLine(rec);
        }
    }
}
