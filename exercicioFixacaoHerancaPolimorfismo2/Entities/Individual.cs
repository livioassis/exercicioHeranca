namespace exercicioFixacaoHerancaPolimorfismo2.Entities
{
    class Individual : TaxPayer
    {

        public double HealthExpenditures { get; set; }

        public Individual()
        {
        }

        public Individual(string name, double anualIncome, double healthExpenditures) : base(name, anualIncome)
        {
            HealthExpenditures = healthExpenditures * 0.5;
        }

        public override double Tax()
        {
            if (AnualIncome < 20000.0)
            {
                return AnualIncome * 0.15 - HealthExpenditures;
            }
            else
            {
                return AnualIncome * 0.25 - HealthExpenditures;
            }
        }
    }
}
