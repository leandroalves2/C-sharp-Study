using System;
using System.Collections.Generic;
using System.Globalization;
using Taxes.Entities;

namespace Taxes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo ci = CultureInfo.InvariantCulture;
            List<TaxesPays> taxesPays = new List<TaxesPays>();

            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++) 
            {
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individual or company (i/c)? ");
                char indOrComp = char.Parse(Console.ReadLine().ToLower());
                if (indOrComp == 'i')
                {
                    Console.Write("Individual name: ");
                    string name = Console.ReadLine();
                    Console.Write("Anual income: ");
                    double anualIncome = double.Parse(Console.ReadLine(), ci);
                    Console.Write("Health expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine(), ci);
                    taxesPays.Add(new Individual(name, anualIncome, healthExpenditures));
                }
                else if (indOrComp == 'c')
                {
                    Console.Write("Company name: ");
                    string name = Console.ReadLine();
                    Console.Write("Anual income: ");
                    double anualIncome = double.Parse(Console.ReadLine(), ci);
                    Console.Write("Number of employees: ");
                    int numberEmployees = int.Parse(Console.ReadLine());
                    taxesPays.Add(new Company(name, anualIncome, numberEmployees));
                }
            }

            Console.WriteLine();
            Console.WriteLine("TAXES PAID:");
            foreach (TaxesPays item in taxesPays)
            {
                Console.WriteLine(item.Name + ": $" + item.IncomeTaxe().ToString("F2", ci));

            }

        }
    }
}
