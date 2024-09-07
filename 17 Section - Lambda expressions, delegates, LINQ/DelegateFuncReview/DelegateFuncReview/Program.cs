// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;
using System.Collections.Generic;
using DelegateFuncReview.Entities;

namespace ActionReview
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();
            products.Add(new Product("TV", 900.00));
            products.Add(new Product("Mouse", 50.00));
            products.Add(new Product("Tablet", 350.50));
            products.Add(new Product("HD Case", 80.90));

            // List<string> strings = products.Select(NameUpper).ToList();

            // Func<Product, string> func = NameUpper;
            // List<string> strings = products.Select(func).ToList();

            // Func<Product, string> func = product => product.Name.ToUpper();
            // List<string> strings = products.Select(func).ToList();

            List<string> strings = products.Select(product => product.Name.ToUpper()).ToList();

            foreach (string str in strings)
            {
                Console.WriteLine(str);
            }

            Console.ReadLine();
        }

        public static string? NameUpper(Product? product)
        {
            return product?.Name?.ToUpper();
        }
    }
}


