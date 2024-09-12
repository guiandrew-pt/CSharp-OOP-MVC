// Console.WriteLine("Hello, World!");

internal class Program
{
    static double PI = 3.14;

    private static void Main(string[] args)
    {
        Console.Write("Type the radius value: ");
        double radius = double.Parse(Console.ReadLine());

        double circumference = Circumference(radius);
        double volume = Volume(radius);

        Console.WriteLine("Circumference: " + circumference.ToString("F2"));
        Console.WriteLine("Volume: " + volume.ToString("F2"));
        Console.WriteLine("Value of PI: " + PI.ToString("F2"));

        Console.ReadLine();
    }

    static double Circumference(double r)
    {
        return 2.0 * PI * r;
    }

    static double Volume(double r)
    {
        return 4.0 / 3.0 * PI * Math.Pow(r, 3);
    }
}