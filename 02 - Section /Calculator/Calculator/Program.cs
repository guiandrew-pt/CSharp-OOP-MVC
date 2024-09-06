// Console.WriteLine("Hello, World!");
using Calculator;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Type the radius value: ");
        double radius = double.Parse(Console.ReadLine());

        double circumference = CalculatorRadius.Circumference(radius);
        double volume = CalculatorRadius.Volume(radius);

        Console.WriteLine("Circumference: " + circumference.ToString("F2"));
        Console.WriteLine("Volume: " + volume.ToString("F2"));
        Console.WriteLine("Value of PI: " + CalculatorRadius.PI.ToString("F2"));

        Console.ReadLine();
    }
}