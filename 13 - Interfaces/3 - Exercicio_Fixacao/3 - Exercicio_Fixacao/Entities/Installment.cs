using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _3___Exercicio_Fixacao.Entities
{
    internal class Installment
    {
        public DateTime DueDate { get; set; }
        public double Amount { get; set; }

        public Installment(DateTime dueDate, double amount)
        {
            DueDate = dueDate;
            Amount = amount;
        }       


        public override string ToString()
        {
           return DueDate.ToString("dd/MM/yyyy") + " - " + Amount;
        }
    }
}
