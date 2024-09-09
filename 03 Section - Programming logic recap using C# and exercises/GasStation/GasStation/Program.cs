// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

//
string str = "Type 1 for Alcohol, 2 for Gasoline, 3 for Diesel, 4 to end the program:";
int alcohol = 0;
int gasoline = 0;
int diesel = 0;

//
Console.WriteLine(str);
int number = Convert.ToInt16(Console.ReadLine());

//
while (number != 4)
{
    if (number == 1)
    {
        alcohol += 1;
    }
    else if (number == 2)
    {
        gasoline += 1;
    }
    else if (number == 3)
    {
        diesel += 1;
    }
    else
    {
        Console.WriteLine("Invalid code.");
    }

    Console.WriteLine(str);
    number = Convert.ToInt16(Console.ReadLine());
}

Console.WriteLine("THANK YOU VERY MUCH.");
Console.WriteLine("Alcohol: " + alcohol);
Console.WriteLine("Gasoline: " + gasoline);
Console.WriteLine("Diesel: " + diesel);
Console.ReadLine();