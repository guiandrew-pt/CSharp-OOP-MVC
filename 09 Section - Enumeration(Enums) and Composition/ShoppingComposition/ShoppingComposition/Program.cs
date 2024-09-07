// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

//
using System.Globalization;
using ShoppingComposition.Entities;
using ShoppingComposition.Entities.Enums;

Console.WriteLine("Enter client data:");

Console.Write("Name: ");
string clientName = Console.ReadLine();

Console.Write("Email: ");
string email = Console.ReadLine();

Console.Write("Birth date (DD/MM/YYYY): ");
DateTime birthDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

Console.WriteLine();

Console.WriteLine("Enter order data:");
Console.Write("Status: (PendingPayment/Processing/Shipped/Delivered): ");
OrderStatus orderStatus = Enum.Parse<OrderStatus>(Console.ReadLine());

Client client = new Client(clientName, email, birthDate);
Order order = new Order(DateTime.Now, orderStatus, client);

Console.Write("How many items to this order: ");
int n = Convert.ToInt16(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    Console.WriteLine();
    Console.WriteLine($"Enter #{i + 1} item data:");

    Console.Write("Product name: ");
    string productName = Console.ReadLine();

    Console.Write("Product price: ");
    double price = double.Parse(Console.ReadLine());

    Console.Write("Quantity: ");
    int quantity = Convert.ToInt16(Console.ReadLine());

    Product product = new Product(productName, price);
    OrderItem orderItem = new OrderItem(quantity, price, product);
    order.AddItem(orderItem);
}

Console.WriteLine();
Console.WriteLine("---------------------");
Console.WriteLine();

Console.WriteLine(order);

Console.ReadLine();

