// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

//
try
{
    int n1 = int.Parse(Console.ReadLine());
    int n2 = int.Parse(Console.ReadLine());

    int result = n1 / n2;
    Console.WriteLine(result);
}
catch (DivideByZeroException)
{
    Console.WriteLine("Division by zero is not allowed!");
}
catch (FormatException e)
{
    Console.WriteLine("Format error! " + e.Message);
}


Console.ReadLine();