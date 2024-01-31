using System;
using System.Dynamic;
using System.Text;

namespace _1___Exemple_Intefaces1
{
    internal class Location
    {

        public string carModel { get; set; }
        public DateTime pickup { get; set; }
        public DateTime returne { get; set; }
        public double pricePerHour { get; set; }
        public double pricePerDay { get; set; }

        public Location(string carModel, DateTime pickup, DateTime returne, double pricePerHour, double pricePerDay)
        {
            this.carModel = carModel;
            this.pickup = pickup;
            this.returne = returne;
            this.pricePerHour = pricePerHour;
            this.pricePerDay = pricePerDay;
        }


        public double BasicPayment()
        {
            TimeSpan duracaoDate = this.returne - this.pickup;
            int duracaoDay = (int)Math.Ceiling(duracaoDate.TotalDays);

            if (duracaoDate.TotalDays < 1 && duracaoDate.TotalHours < 12)
            {
                int duracaohour = (int)Math.Ceiling(duracaoDate.TotalHours);

                double sum = duracaohour * this.pricePerHour;
                return sum;

            }
            else
            {
                double sum = Math.Ceiling(duracaoDate.TotalDays) * pricePerDay;
                return sum;
            }
        }

        public double TotalPayment()
        {
            if (BasicPayment() <= 100.00)
            {
                double tax = BasicPayment() * 0.20;
                return tax + BasicPayment();
            }
            else
            {
                double tax = BasicPayment() * 0.15;
                return tax + BasicPayment();
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Basic payment: " + BasicPayment());
            if (BasicPayment() <= 100.00)
            {
                sb.AppendLine("Tax: " + BasicPayment() * 0.20);
            }
            else
            {
                sb.AppendLine("Tax: " + BasicPayment() * 0.15);

            }
            sb.AppendLine("Total payment: " + TotalPayment());
            return sb.ToString();
        }

    }
}
