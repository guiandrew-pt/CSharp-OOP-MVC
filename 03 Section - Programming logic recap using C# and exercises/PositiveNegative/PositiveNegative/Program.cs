// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// Variables:
string str = "Type a integer number:";

//
Console.WriteLine(str);
int num = Convert.ToInt16(Console.ReadLine());

//
if (num < 0)
{
    Console.WriteLine("NEGATIVE");
}
else
{
    Console.WriteLine("NOT NEGATIVE");
}

Console.ReadLine();