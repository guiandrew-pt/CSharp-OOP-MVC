// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

//
string str = "Type one integer number: ";

//
Console.Write(str);
int number = Convert.ToInt16(Console.ReadLine());

//
for (int i = 1; i <= number; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
    }
}

Console.ReadLine();
