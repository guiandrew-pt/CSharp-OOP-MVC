// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// Variable:
string str = "Type the circle radius:";
double pi = 3.14159;

//
Console.WriteLine(str);
double typed = Convert.ToDouble(Console.ReadLine());

double area = pi * (typed * typed);

Console.WriteLine("A = " + area.ToString("F4"));
Console.ReadLine();


