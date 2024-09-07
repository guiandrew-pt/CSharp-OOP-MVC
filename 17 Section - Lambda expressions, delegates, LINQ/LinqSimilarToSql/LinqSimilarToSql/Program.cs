// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using LinqSimilarToSql.Entities;

internal class Program
{
    private static void Main(string[] args)
    {
        Category category1 = new Category { Id = 1, Name = "Tools", Tier = 2 };
        Category category2 = new Category { Id = 2, Name = "Computers", Tier = 1 };
        Category category3 = new Category { Id = 3, Name = "Electronics", Tier = 1 };

        List<Product> products = new List<Product>
        {
            new Product { Id = 1, Name = "Computer", Price = 1100.0, Category = category2 },
            new Product { Id = 2, Name = "Hammer", Price = 90.0, Category = category1 },
            new Product { Id = 3, Name = "TV", Price = 1700.0, Category = category3 },
            new Product { Id = 4, Name = "Notebook", Price = 1300.0, Category = category2 },
            new Product { Id = 5, Name = "Saw", Price = 80.0, Category = category1 },
            new Product { Id = 6, Name = "Tablet", Price = 700.0, Category = category2 },
            new Product { Id = 7, Name = "Camera", Price = 700.0, Category = category3 },
            new Product { Id = 8, Name = "Printer", Price = 350.0, Category = category3 },
            new Product { Id = 9, Name = "MacBook", Price = 1800.0, Category = category2 },
            new Product { Id = 10, Name = "Sound Bar", Price = 700.0, Category = category3 },
            new Product { Id = 11, Name = "Level", Price = 70.0, Category = category1 }
        };

        // IEnumerable<Product> result1 = products.Where(p => p.Category?.Tier == 1 && p.Price < 900.0);
        IEnumerable<Product> result1 = from product in products
                                       where product.Category?.Tier == 1
                                       && product.Price < 900.0
                                       select product;
        Print("TIER 1 AND PRICE < $900:", result1);

        // IEnumerable<string> result2 = products.Where(p => p.Category?.Name == "Tools").Select(p => p.Name);
        IEnumerable<string> result2 = from p in products
                                      where p.Category?.Name == "Tools"
                                      select p.Name;
        Print("NAMES OF PRODUCTS FROM TOOLS:", result2);

        // var result3 = products.Where(p => p.Name[0] == 'C').Select(p => new { p.Name, p.Price, CategoryName = p.Category?.Name });
        var result3 = from p in products
                      where p.Name[0] == 'C'
                      select new
                      {
                          p.Name,
                          p.Price,
                          CategoryName = p.Category?.Name
                      };
        Print("NAMES STARTED WITH 'C' AND ANONYMOUS OBJECT", result3);

        // IOrderedEnumerable<Product> result4 = products.Where(p => p.Category?.Tier == 1).OrderBy(p => p.Price).ThenBy(p => p.Name);
        IOrderedEnumerable<Product> result4 = from p in products
                                              where p.Category?.Tier == 1
                                              orderby p.Name
                                              orderby p.Price
                                              select p;
        Print("TIER 1 ORDER BY PRICE THEN BY NAME", result4);

        // IEnumerable<Product> result5 = result4.Skip(2).Take(4);
        IEnumerable<Product> result5 = (from p in result4
                                        select p).Skip(2).Take(4);
        Print("TIER 1 ORDER BY PRICE THEN BY NAME SKIP 2 TAKE 4", result5);

        // Product? result6 = products.FirstOrDefault();
        Product? result6 = (from p in products
                            select p).FirstOrDefault();
        Console.WriteLine("First or default test1: " + result6);

        Console.WriteLine();

        // Product? result7 = products.Where(p => p.Price > 3000.0).FirstOrDefault();
        Product? result7 = (from p in products
                            where p.Price > 3000.0
                            select p).FirstOrDefault();
        Console.WriteLine("First or default test2: " + result7);

        Console.WriteLine();

        // Product? result8 = products.Where(p => p.Id == 3).SingleOrDefault();
        Product? result8 = (from p in products
                            where p.Id == 3
                            select p).SingleOrDefault();
        Console.WriteLine("Single or default test1: " + result8);

        Console.WriteLine();

        // Product? result9 = products.Where(p => p.Id == 30).SingleOrDefault();
        Product? result9 = (from p in products
                            where p.Id == 30
                            select p).SingleOrDefault();
        Console.WriteLine("Single or default test2: " + result9);

        Console.WriteLine();

        // IEnumerable<IGrouping<Category, Product>> result16 = products.GroupBy(p => p.Category);
        IEnumerable<IGrouping<Category, Product>> result16 = from p in products
                                                             group p by p.Category;
        foreach (IGrouping<Category, Product> group in result16)
        {
            Console.WriteLine("Category " + group.Key.Name + ":");

            foreach (Product product in group)
            {
                Console.WriteLine(product);
            }

            Console.WriteLine();
        }

        Console.ReadLine();
    }

    public static void Print<T>(string message, IEnumerable<T> collection)
    {
        Console.WriteLine(message);

        foreach (T obj in collection)
        {
            Console.WriteLine(obj);
        }

        Console.WriteLine();
    }
}
