// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// DIFFERENCE = (A * B - C * D)

// Variables:
string str = "Type four integer number, slit by space:";

//
Console.WriteLine(str);
string[] numbers = Console.ReadLine().Split(' ');

//
int a = Convert.ToInt16(numbers[0]);
int b = Convert.ToInt16(numbers[1]);
int c = Convert.ToInt16(numbers[2]);
int d = Convert.ToInt16(numbers[3]);

//
int difference = (a * b) - (c * d);

//
Console.WriteLine("DIFFERENCE = " + difference);
Console.ReadLine();

