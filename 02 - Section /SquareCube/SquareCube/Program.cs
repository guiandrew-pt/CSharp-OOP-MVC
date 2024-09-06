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
    int firtRow = i;
    int secondRow = i * i;
    int threeRow = i * i * i;

    Console.WriteLine($"{firtRow} {secondRow} {threeRow}");
}

Console.ReadLine();