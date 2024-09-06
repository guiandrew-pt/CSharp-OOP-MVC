// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

//
string str = "Type a integer number: ";

//
Console.Write(str);
int n = Convert.ToInt16(Console.ReadLine());

//
for (int i = 1; i <= n; i++)
{
    if (n % i == 0)
    {
        Console.WriteLine(i);
    }
}

Console.ReadLine();
