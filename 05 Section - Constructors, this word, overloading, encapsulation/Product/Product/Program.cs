// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

//
using Product;

// Variables:
string str = "Type the data of the product:";

//
ProductI p = new ProductI("TV", 900.00, 10);

// Console.WriteLine(p.Name);

p.Name = "T";

Console.WriteLine(p.Name);
Console.WriteLine(p.Price);
Console.WriteLine(p.Amount);

Console.ReadLine();
