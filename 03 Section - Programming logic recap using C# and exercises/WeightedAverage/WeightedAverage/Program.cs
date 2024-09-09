// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

//
string str1 = "Type a integer number: ";
string str2 = "Type three decimal numbers, split by space: ";

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
    double c = double.Parse(numbers[2]);

    double average = (a * 2.0 + b * 3.0 + c * 5.0) / 10.0;

    Console.WriteLine(average.ToString("F1"));
}

Console.ReadLine();


