using Account_Heranca.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Account_Heranca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account cc1 = new Account(1234, "Leandro Alves", 1000.00);
            Account cc2 = new SavingsAccount(4321, "Leandro Silva", 1000.00, 0.02);
            cc1.Withdraw(200.00);
            cc2.Withdraw(200.00);
            Console.WriteLine("cc1 = " + cc1.Balance);
            Console.WriteLine("cc2 = " + cc2.Balance);

        }

    }
}
