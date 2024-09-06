// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// Variables:
string str = "Type a number:";

//
Console.WriteLine(str);
double number = Convert.ToDouble(Console.ReadLine());

//
if (number < 0.0 || number > 100.0)
{
    Console.WriteLine("Out of interval");
}
else if (number <= 25.0)
{
    Console.WriteLine("Interval [0, 25]");
}
else if (number <= 50.0)
{
    Console.WriteLine("Interval (25, 50]");
}
else if (number <= 75.0)
{
    Console.WriteLine("Interval (50, 75]");
}
else
{
    Console.WriteLine("Interval (75, 100]");
}

Console.ReadLine();