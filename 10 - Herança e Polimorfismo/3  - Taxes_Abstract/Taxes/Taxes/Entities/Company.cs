namespace Taxes.Entities
{
    internal class Company : TaxesPays
    {
        public int NumberEmployees { get; set; }

        public Company() { }
        public Company(string name, double anualIncome, int numberEmployees) 
            : base(name, anualIncome)
        {
            NumberEmployees = numberEmployees;
        }

        public override double IncomeTaxe()
        {
            if (NumberEmployees > 10)
            {
                return AnualIncome * 0.14;
            }
            else
            {
                return AnualIncome * 0.16;
            }
        }
    }
}
