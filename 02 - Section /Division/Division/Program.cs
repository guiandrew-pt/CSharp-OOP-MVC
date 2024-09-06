// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

//
string str1 = "Type a integer number: ";
string str2 = "Type two integer number, split by comma: ";

//
Console.Write(str1);
int n = Convert.ToInt16(Console.ReadLine());

//
for (int i = 0; i < n; i++)
{
    Console.WriteLine(str2);
    string[] numbers = Console.ReadLine().Split(" ");

    double a = double.Parse(numbers[0]);
    double b = double.Parse(numbers[1]);

    if (b == 0)
    {
        Console.WriteLine("Division is impossible");
    }
    else
    {
        double division = a / b;
        Console.WriteLine(division.ToString("F1"));
    }
}

Console.ReadLine();


