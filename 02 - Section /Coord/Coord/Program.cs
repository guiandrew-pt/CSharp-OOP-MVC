// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

//
string str = "Type two integers numbers: ";

//
Console.WriteLine(str);
string[] numbers = Console.ReadLine().Split(' ');

int x = Convert.ToInt16(numbers[0]);
int y = Convert.ToInt16(numbers[1]);

//
while (x != 0 && y != 0)
{
    if (x > 0 && y > 0)
    {
        Console.WriteLine("First");
    }
    else if (x < 0 && y > 0)
    {
        Console.WriteLine("Second");
    }
    else if (x < 0 && y < 0)
    {
        Console.WriteLine("Third");
    }
    else
    {
        Console.WriteLine("Fourth");
    }

    Console.WriteLine(str);
    numbers = Console.ReadLine().Split(' ');

    x = Convert.ToInt16(numbers[0]);
    y = Convert.ToInt16(numbers[1]);
}

Console.ReadLine();

