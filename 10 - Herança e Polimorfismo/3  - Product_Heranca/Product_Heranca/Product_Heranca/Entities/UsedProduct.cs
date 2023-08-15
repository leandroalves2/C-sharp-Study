using System;
using System.Globalization;

namespace Product_Heranca.Entities
{
    internal class UsedProduct : Product
    {
        CultureInfo ci = CultureInfo.InvariantCulture;
        public DateTime ManufactureDate { get; set; }

        public UsedProduct() { }
        public UsedProduct(string name, double price, DateTime manufactureDate) 
            : base(name, price)
        {
            ManufactureDate = manufactureDate;
        }

        public override string PriceTag()
        {
            return Name + " $" + Price.ToString("F2", ci) + " (Manufacture date: " + ManufactureDate.ToString("dd/MM/yyyy") + ")";
        }
    }
}
