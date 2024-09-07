// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

//
using AvgPrice;

Console.Write("Type the amount of product(s): ");
int n = Convert.ToInt16(Console.ReadLine());

Product[] product = new Product[n];

Console.WriteLine();

// 
for (int i = 0; i < n; i++)
{
    Console.Write("Product name: ");
    string name = Console.ReadLine();

    Console.Write("Product price: ");
    double price = double.Parse(Console.ReadLine());

    product[i] = new Product
    {
        Name = name,
        Price = price
    };
}

double sum = 0.0;

for (int i = 0; i < n; i++)
{
    sum += product[i].Price;
}

double avg = sum / n;

Console.WriteLine();

Console.WriteLine("Average price: $" + avg.ToString("F2"));

Console.ReadLine();

