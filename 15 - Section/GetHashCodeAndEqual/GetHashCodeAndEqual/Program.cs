// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//
/*
string a = "Maria";
string b = "Alex";

Console.WriteLine(a.Equals(b));
Console.WriteLine("====================");
Console.WriteLine(a.GetHashCode());
Console.WriteLine(b.GetHashCode());
*/

using GetHashCodeAndEqual.Entities;

Client clientA = new Client { Name = "Maria", Email = "maria@gmail.com" };
Client clientB = new Client { Name = "Alex", Email = "alex@gmail.com" };

Console.WriteLine(clientA.Equals(clientB));
Console.WriteLine(clientA == clientB);
Console.WriteLine(clientA.GetHashCode());
Console.WriteLine(clientB.GetHashCode());

Console.ReadLine();
