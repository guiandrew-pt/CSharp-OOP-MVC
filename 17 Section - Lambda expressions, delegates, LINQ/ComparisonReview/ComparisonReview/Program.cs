// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;
using ComparisonReview.Entities;

internal class Program
{
    private static void Main(string[] args)
    {
        //
        List<Product> products = new List<Product>();
        products.Add(new Product("TV", 900.00));
        products.Add(new Product("Notebook", 1200.00));
        products.Add(new Product("Tablet", 450.00));

        // products.Sort(CompareProducts);

        // Comparison<Product> comparison = CompareProducts;
        // products.Sort(comparison);

        // Comparison<Product> comparison = (p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name?.ToUpper());
        // products.Sort(comparison);
        products.Sort((p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name?.ToUpper()));

        foreach (Product product in products)
        {
            Console.WriteLine(product);
        }

        Console.ReadLine();
    }

    /* static int CompareProducts(Product firstProduct, Product secondProduct)
    {
        return firstProduct.Name.ToUpper().CompareTo(secondProduct?.Name?.ToUpper());
    } */
}