// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

//
using TaxesPaid.Entities;

//
List<TaxPayer> taxPayers = new List<TaxPayer>();

Console.Write("Enter the number of tax payers: ");
int numberTaxPayers = Convert.ToInt16(Console.ReadLine());

for (int i = 0; i < numberTaxPayers; i++)
{
    Console.WriteLine($"Tax payer #{i + 1} data:");
    Console.Write("Individual or company (i/c)? ");
    char answer = char.Parse(Console.ReadLine());

    Console.Write("Name: ");
    string name = Console.ReadLine();

    Console.Write("Anual income: ");
    double anualIncome = double.Parse(Console.ReadLine());

    if (answer == 'i')
    {
        Console.Write("Health expenditures: ");
        double healthExpenditures = double.Parse(Console.ReadLine());

        taxPayers.Add(new Individual(name, anualIncome, healthExpenditures));
    }
    else
    {
        Console.Write("Number of employees: ");
        int numberEmployees = Convert.ToInt16(Console.ReadLine());

        taxPayers.Add(new Company(name, anualIncome, numberEmployees));
    }
}

double total = 0.0;

Console.WriteLine();
Console.WriteLine("TAXES PAID:");

foreach (TaxPayer taxPayer in taxPayers)
{
    double tax = taxPayer.Tax();
    Console.WriteLine($"{taxPayer.Name}: ${tax.ToString("F2")}");
    total += tax;
}

Console.WriteLine();
Console.WriteLine($"TOTAL TAXES: ${total.ToString("F2")}");

Console.ReadLine();