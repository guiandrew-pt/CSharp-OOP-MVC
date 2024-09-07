// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


//
string str = "Type the amount:";
string type = "Type a number:";
int numbersIn = 0;
int numbersOut = 0;

Console.WriteLine(str);
int n = Convert.ToInt16(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    Console.WriteLine(type);
    int x = Convert.ToInt16(Console.ReadLine());

    if (x >= 10 && x <= 20)
    {
        numbersIn++;
    }
    else
    {
        numbersOut++;
    }
}

Console.WriteLine("Numbers In: " + numbersIn);
Console.WriteLine("Numbers Out: " + numbersOut);

Console.ReadLine();