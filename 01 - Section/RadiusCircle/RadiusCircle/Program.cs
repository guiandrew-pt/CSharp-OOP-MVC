// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// Formula: area = r.radius^2
// PI value = 3.14159

// Variables:
double pi = 3.14159;
string str = "Type a number:";
double typedNumber = 0.0;
double area = 0.0;
string a = "Area = ";

//
Console.WriteLine(str);
typedNumber = Convert.ToDouble(Console.ReadLine());

//
area = pi * typedNumber * typedNumber;

Console.WriteLine(a + area.ToString("F4"));

Console.ReadLine();