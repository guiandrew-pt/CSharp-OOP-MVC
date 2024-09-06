// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// Variables:
string str = "Type 3 numbers(Floats):";
double pi = 3.14159;

//
Console.WriteLine(str);
string[] numbers = Console.ReadLine().Split(' ');

//
double a = Convert.ToDouble(numbers[0]);
double b = Convert.ToDouble(numbers[1]);
double c = Convert.ToDouble(numbers[2]);

// Right Triangle = (A * C) / 2
double triangle = (a * c) / 2.0;

// Circle = pi * c * c
double circle = pi * c * c;

// Trapeze = (a + b) / 2.0 * c;
double trapeze = (a + b) / 2.0 * c;

// Square = b * b;
double square = b * b;

// Rectangle = A * B;
double rectangle = a * b;

//
Console.WriteLine("Triangle: " + triangle.ToString("F3"));
Console.WriteLine("Circle: " + circle.ToString("F3"));
Console.WriteLine("Trapeze: " + trapeze.ToString("F3"));
Console.WriteLine("Square: " + square.ToString("F3"));
Console.WriteLine("Rectangle: " + rectangle.ToString("F3"));

Console.ReadLine();

