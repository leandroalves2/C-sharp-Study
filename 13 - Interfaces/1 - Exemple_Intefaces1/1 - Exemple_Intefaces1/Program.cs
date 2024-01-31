using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1___Exemple_Intefaces1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo ci = CultureInfo.InvariantCulture;

            Console.WriteLine("Enter rental data");

            Console.Write("Car model: ");
            string car = Console.ReadLine();

            Console.Write("Pickup (dd/MM/yyyy hh:mm): ");
            string dateVar = Console.ReadLine();
            DateTime pickup = DateTime.ParseExact(dateVar, "dd/MM/yyyy HH:mm", ci);

            Console.Write("Return (dd/MM/yyyy hh:mm): ");
            dateVar = Console.ReadLine();
            DateTime returne = DateTime.ParseExact(dateVar, "dd/MM/yyyy HH:mm", ci);

            Console.Write("Enter price per hour: ");
            double pricePerHour = double.Parse(Console.ReadLine(), ci);

            Console.Write("Enter price per day: ");
            double pricePerDay = double.Parse(Console.ReadLine(), ci);

            Console.WriteLine();

            Location test = new Location(car, pickup, returne, pricePerHour, pricePerDay);
            Console.WriteLine(test);
        }
    }
}