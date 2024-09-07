// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

//
Console.Write("Type the array length: ");
int n = Convert.ToInt16(Console.ReadLine());

Console.WriteLine();

double[] arr = new double[n];

for (int i = 0; i < n; i++)
{
    Console.Write("Type a Height: ");
    arr[i] = double.Parse(Console.ReadLine());
}

double sum = 0.0;

for (int i = 0; i < n; i++)
{
    sum += arr[i];
}

double avg = sum / n;

Console.WriteLine();
Console.Write("Average Height: " + avg.ToString("F2"));

Console.ReadLine();
