// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using GenericsReview.Services;

//
PrintService<int> printService = new PrintService<int>();

Console.Write("How many values? ");
int n = Convert.ToInt16(Console.ReadLine());

for (int i = 0; i < n; i++)
{

    int x = Convert.ToInt16(Console.ReadLine());
    printService.AddValue(x);
}

int a = printService.First();
int b = a + 2;
Console.WriteLine(b);

Console.WriteLine();

printService.Print();
Console.WriteLine();
Console.WriteLine($"First: {printService.First()}");

Console.ReadLine();