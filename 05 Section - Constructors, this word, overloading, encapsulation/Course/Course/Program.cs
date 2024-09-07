// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using Course;

// Variables:
string str = "Type the data of the product:";

//
Console.WriteLine(str);

Console.Write("Name: ");
string name = Console.ReadLine();

Console.Write("Price: ");
double price = double.Parse(Console.ReadLine());

/*Console.Write("Stock amount: ");
int amount = Convert.ToInt16(Console.ReadLine());*/

/*Product p = new Product(name, price, amount); */
Product p = new Product(name, price);

//
Console.WriteLine();
Console.WriteLine("Product data: " + p);

//
/*Console.WriteLine();
Console.Write("Type the amount of products you want to add: ");

amount = Convert.ToUInt16(Console.ReadLine());
p.AddStock(amount);*/

//
Console.WriteLine();
Console.WriteLine("Updated product: " + p);

//
/*Console.WriteLine();
Console.Write("Type the amount of products you want to remove: ");

amount = Convert.ToUInt16(Console.ReadLine());
p.RemoveStock(amount);*/

//
Console.WriteLine();
Console.WriteLine("Updated product: " + p);

Console.ReadLine();
