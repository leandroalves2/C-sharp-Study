using System.Globalization;

namespace Product_Heranca.Entities
{
    internal class Product
    {
        CultureInfo ci = CultureInfo.InvariantCulture;
        public string Name { get; set; }
        public double Price { get; set; }

        public Product() { }
        public Product(string name, double price) 
        {
            Name = name;
            Price = price;
        }

        public virtual string PriceTag()
        {
            return Name + " $" + Price.ToString("F2", ci);
        }

    }
}
