namespace Taxes.Entities
{
    internal abstract class TaxesPays
    {
        public string Name { get; set; }
        public double AnualIncome { get; set; }

        public TaxesPays() { }

        protected TaxesPays(string name, double anualIncome)
        {
            Name = name;
            AnualIncome = anualIncome;
        }

        public abstract double IncomeTaxe();


    }
}
