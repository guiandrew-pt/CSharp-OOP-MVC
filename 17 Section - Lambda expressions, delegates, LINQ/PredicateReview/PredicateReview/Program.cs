// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using PredicateReview.Entities;

namespace PredicateReview
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

            // products.RemoveAll(p => p.Price >= 100.00);
            products.RemoveAll(ProductBiggerOrEqual100);

            foreach (Product product in products)
            {
                Console.WriteLine(product);
            }

            Console.ReadLine();
        }

        public static bool ProductBiggerOrEqual100(Product product)
        {
            return product.Price >= 100.0;
        }
    }
}