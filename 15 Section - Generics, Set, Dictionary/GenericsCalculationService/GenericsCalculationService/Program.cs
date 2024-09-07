// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using GenericsCalculationService.Entities;
using GenericsCalculationService.Services;

//
List<Product> list = new List<Product>();

Console.Write("Enter N: ");
int n = Convert.ToInt16(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    string[] arr = Console.ReadLine().Split(',');
    string name = arr[0];
    double price = double.Parse(arr[1]);
    
    list.Add(new Product(name, price));
}

CalculationService calculationService = new CalculationService();

Product max = calculationService.Max(list);

Console.Write($"Most expensive(MAX): {max}");

Console.ReadLine();