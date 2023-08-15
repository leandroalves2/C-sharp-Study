using System.Globalization;

namespace Product_Heranca.Entities
{
    internal class ImportedProduct: Product
    {
        CultureInfo ci = CultureInfo.InvariantCulture;
        public double CustomFree { get; set; }

        public ImportedProduct(string name, double price, double customFree)
            : base(name, price)
        {
            CustomFree = customFree;
        }

        public double TotalPrice(double customFree)
        {
            return base.Price + CustomFree;
        }
        public override string PriceTag()
        {
            return base.Name + " $" + TotalPrice(CustomFree).ToString() + " (Customs fee: $ " + CustomFree.ToString("F2", ci) + ")";
        }

    }
}
