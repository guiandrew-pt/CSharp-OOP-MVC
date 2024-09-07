// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

//
using System.Globalization;
using HeritageProdut.Entities;

//
List<Product> products = new List<Product>();

Console.Write("Enter the number of produts: ");
int numberOrProduts = Convert.ToInt16(Console.ReadLine());

for (int i = 0; i < numberOrProduts; i++)
{
    Console.WriteLine();

    Console.WriteLine($"Product #{i + 1} data:");
    Console.Write("Common, used or imported (c/u/i)? ");
    char answer = char.Parse(Console.ReadLine());

    Console.Write("Name: ");
    string productName = Console.ReadLine();

    Console.Write("Price: ");
    double price = double.Parse(Console.ReadLine());

    if (answer == 'c' || answer == 'C')
    {
        products.Add(new Product(productName, price));
    }
    else if (answer == 'u' || answer == 'U')
    {
        Console.Write("Manufacture date (DD/MM/YYYY): ");
        DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

        products.Add(new UsedProduct(productName, price, date));
    }
    else if(answer == 'i' || answer == 'I')
    {
        Console.Write("Customs fee: ");
        double fee = double.Parse(Console.ReadLine());

        products.Add(new ImportedProduct(productName, price, fee));
    }
}

Console.WriteLine();
Console.WriteLine("---------------");
Console.WriteLine();

Console.WriteLine("PRICE TAGS:");

foreach (Product product in products)
{
    Console.WriteLine(product.PriceTag());
}

Console.ReadLine();

