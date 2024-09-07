// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// Variables:
string str1 = "Type the first number(integer):";
string str2 = "Type the second number(integer):";

Console.WriteLine(str1);
int typed1 = Convert.ToInt16(Console.ReadLine());

Console.WriteLine(str2);
int typed2 = Convert.ToInt16(Console.ReadLine());

int sum = typed1 + typed2;

Console.WriteLine("Sum = " + sum);
Console.ReadLine();
