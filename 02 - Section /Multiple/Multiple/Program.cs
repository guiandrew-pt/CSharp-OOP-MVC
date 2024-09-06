// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// Variables:
string str = "Type two integers numbers, split by comma:";

//
Console.WriteLine(str);
string[] numbers = Console.ReadLine().Split(' ');

//
int a = Convert.ToInt16(numbers[0]);
int b = Convert.ToInt16(numbers[1]);

//
if ((a % b) == 0 || (b % a) == 0)
{
    Console.WriteLine("MULTIPLES");
}
else
{
    Console.WriteLine("NOT MULTIPLES");
}

Console.ReadLine();
