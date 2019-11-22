using exercicioFixacaoHerancaPolimorfismo2.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace exercicioFixacaoHerancaPolimorfismo2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TaxPayer> list = new List<TaxPayer>();

            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individual or company (i/c)? ");

                char type = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Anual income: ");
                double income = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (type == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double healthExp = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new Individual(name, income, healthExp));
                }
                else
                {
                    Console.Write("Number of employees: ");
                    int numbOfEmpl = int.Parse(Console.ReadLine());

                    list.Add(new Company(name, income, numbOfEmpl));
                }
            }


            Console.WriteLine();
            Console.WriteLine("TAXES PAID:");

            double totalTax = 0.0;

            foreach (TaxPayer payer in list)
            {
                Console.WriteLine(payer);
                totalTax += payer.Tax();
            }

            Console.WriteLine();
            Console.WriteLine("TOTAL TAXES: $ " + totalTax.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
