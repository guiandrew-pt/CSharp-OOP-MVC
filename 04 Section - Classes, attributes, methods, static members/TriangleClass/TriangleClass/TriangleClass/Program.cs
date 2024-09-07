// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using TriangleClass;

//
Triangle x = new Triangle();
Triangle y = new Triangle();

//
Console.WriteLine("Type the measures of the triangle X:");
x.A = double.Parse(Console.ReadLine());
x.B = double.Parse(Console.ReadLine());
x.C = double.Parse(Console.ReadLine());

Console.WriteLine("Type the measures of the triangle Y:");
y.A = double.Parse(Console.ReadLine());
y.B = double.Parse(Console.ReadLine());
y.C = double.Parse(Console.ReadLine());

//
double areaX = x.Area();

double areaY = y.Area();

//
Console.WriteLine("X Area = " + areaX.ToString("F4"));
Console.WriteLine("Y Area = " + areaY.ToString("F4"));

if (areaX > areaY)
{
    Console.WriteLine("Bigger Area: X");
}
else
{
    Console.WriteLine("Bigger Area: Y");
}

Console.ReadLine();