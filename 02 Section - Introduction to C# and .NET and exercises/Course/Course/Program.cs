// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using Course;

// Variables:
string str = "Type the data of the product:";
Product p = new Product();

//
Console.WriteLine(str);

Console.Write("Name: ");
p.Name = Console.ReadLine();

Console.Write("Price: ");
p.Price = double.Parse(Console.ReadLine());

Console.Write("Stock amount: ");
p.Amount = Convert.ToInt16(Console.ReadLine());

//
Console.WriteLine();
Console.WriteLine("Product data: " + p);

//
Console.WriteLine();
Console.Write("Type the amount of products you want to add: ");

int amount = Convert.ToUInt16(Console.ReadLine());
p.AddStock(amount);

//
Console.WriteLine();
Console.WriteLine("Updated product: " + p);

//
Console.WriteLine();
Console.Write("Type the amount of products you want to remove: ");

amount = Convert.ToUInt16(Console.ReadLine());
p.RemoveStock(amount);

//
Console.WriteLine();
Console.WriteLine("Updated product: " + p);

Console.ReadLine();
