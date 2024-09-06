// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// Variables:
string str = "Type the inicial hour and the final hour, split by comma:";

//
Console.WriteLine(str);
string[] numbers = Console.ReadLine().Split(' ');

//
int inicial = Convert.ToInt16(numbers[0]);
int final = Convert.ToInt16(numbers[1]);

//
int duration = 0;
if (inicial < final)
{
    duration = final - inicial;
}
else
{
    duration = 24 - inicial + final;
}

Console.WriteLine("Game duration: " + duration + " hour(s).");

Console.ReadLine();