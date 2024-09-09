// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// Variables:
string str = "Type two decimal numbers, split by space:";

//
Console.WriteLine(str);
string[] numbers = Console.ReadLine().Split(' ');

//
double x = double.Parse(numbers[0]);
double y = double.Parse(numbers[1]);

//
if (x == 0.0 && y == 0.0)
{
    Console.WriteLine("Origem");
}
else if (x == 0.0)
{
    Console.WriteLine("X Axle");
}
else if (y == 0.0)
{
    Console.WriteLine("Y Axle");
}
else if (x > 0.0 && y > 0.0)
{
    Console.WriteLine("Q1");
}
else if (x < 0.0 && y > 0.0)
{
    Console.WriteLine("Q2");
}
else if (x < 0.0 && y < 0.0)
{
    Console.WriteLine("Q3");
}
else
{
    Console.WriteLine("Q4");
}

Console.ReadLine();

