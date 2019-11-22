namespace exercicioFixacaoHerancaPolimorfismo2.Entities
{
    class Company : TaxPayer
    {

        public int NumberOfEmployees { get; set; }

        public Company()
        {
        }

        public Company(string name, double anualIncome, int numberOfEmployees) : base(name, anualIncome)
        {
            NumberOfEmployees = numberOfEmployees;
        }

        public override double Tax()
        {
            double taxes;
            
            if (NumberOfEmployees > 10)
            {
                taxes = AnualIncome * 0.14;
            }
            else
            {
                taxes = AnualIncome * 0.16;
            }

            return taxes;
        }
    }
}
