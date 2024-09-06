// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;
using ActionReview.Entities;

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

            // products.ForEach(UpdatePrice);

            // Action<Product> action = UpdatePrice;
            // products.ForEach(action);

            // Action<Product> action = p => { p.Price += p.Price * 0.1; };
            // products.ForEach(action);

            products.ForEach(p => { p.Price += p.Price * 0.1; });

            foreach (Product product in products)
            {
                Console.WriteLine(product);
            }

            Console.ReadLine();
        }

        public static void UpdatePrice(Product product)
        {
            product.Price += product.Price * 0.1;
        }
    }
}







