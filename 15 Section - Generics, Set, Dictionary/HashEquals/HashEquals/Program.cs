// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using HashEquals.Entities;

//
/*
HashSet<string> set = new HashSet<string>();
set.Add("Maria");
set.Add("Alex");

Console.WriteLine(set.Contains("Maria"));
*/

// 
HashSet<Product> products = new HashSet<Product>();
products.Add(new Product("TV", 900.00));
products.Add(new Product("Notebook", 1200.00));

HashSet<Point> points = new HashSet<Point>();
points.Add(new Point(3, 4));
points.Add(new Point(5, 10));

Product product = new Product("Notebook", 1200.00);

Console.WriteLine(products.Contains(product));

Point point = new Point(5, 10);
Console.WriteLine(points.Contains(point));

Console.ReadLine();