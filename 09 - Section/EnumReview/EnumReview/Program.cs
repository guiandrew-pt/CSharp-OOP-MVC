// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

//
using EnumReview.Entities;
using EnumReview.Entities.Enums;

Order order = new Order
{
    Id = 1080,
    Moment = DateTime.Now,
    Status = OrderStatus.Processing
};

Console.WriteLine(order);

string str = OrderStatus.PendingPayment.ToString();

Console.WriteLine(str);

OrderStatus orderStatus = Enum.Parse<OrderStatus>("Delivered");

Console.WriteLine(orderStatus);

Console.ReadLine();