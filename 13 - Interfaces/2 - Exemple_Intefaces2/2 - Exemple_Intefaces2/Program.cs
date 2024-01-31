using _2___Exemple_Intefaces2.Entities;
using _2___Exemple_Intefaces2.Services;
using System;
using System.Globalization;

namespace _2___Exemple_Intefaces2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            CultureInfo ci = CultureInfo.InvariantCulture;

            Console.WriteLine("Enter rental data");

            Console.Write("Car model: ");
            string model = Console.ReadLine();

            Console.Write("Pickup (dd/MM/yyyy hh:mm): ");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", ci);

            Console.Write("Return (dd/MM/yyyy hh:mm): ");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", ci);

            Console.Write("Enter price per hour: ");
            double hour = double.Parse(Console.ReadLine(), ci);

            Console.Write("Enter price per day: ");
            double hodayur = double.Parse(Console.ReadLine(), ci);

            CarRental carRental = new CarRental(start, finish, new Vehicle(model));

            RentalService rentalService = new RentalService(hour, hodayur, new BrazilTaxService());

            rentalService.ProcessInvoice(carRental);

            Console.WriteLine();
            Console.WriteLine("INVOICE: ");
            Console.WriteLine(carRental.Invoice);
        }
    }
}
