// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using CsvLambda.Entities;

string source = "/Applications/Study/Udemy/05 - C# COMPLETO Programação Orientada a Objetos + Projetos/17 - Section 17/File/in.txt";

Console.Write("Enter the full file path: ");
string? path = Console.ReadLine();

List<Product> products = new List<Product>();

using (StreamReader sr = File.OpenText(path))
{
    while (!sr.EndOfStream)
    {
        string[] fields = sr.ReadLine().Split(',');
        string name = fields[0];
        double price = double.Parse(fields[1]);

        products.Add(new Product(name, price));
    }
}

double avg = products.Select(p => p.Price).DefaultIfEmpty(0.0).Average();

Console.WriteLine($"Average price = {avg.ToString("F2")}");

IEnumerable<string> names = products.Where(p => p.Price < avg).OrderByDescending(p => p.Name).Select(p => p.Name);
foreach (string name in names)
{
    Console.WriteLine(name);
}

Console.ReadLine();