// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// Bhaskara
// x = (-b+-SQRootDelta) / 2a
// Where Delta = b^2 - 4ac
// Delta: 

// Variables:
string str = "Type three numbers, split with the space.";
string impossible = "Impossible to calculate!";
double x1;
double x2;

//
Console.WriteLine(str);
string[] valuesArr = Console.ReadLine().Split(" ");

//
double a = Convert.ToDouble(valuesArr[0]);
double b = Convert.ToDouble(valuesArr[1]);
double c = Convert.ToDouble(valuesArr[2]);

//
double delta = b * b - 4 * a * c;

//
if (a == 0.0 || delta < 0.0)
{
    Console.WriteLine(impossible);
    // Environment.Exit(0);
}
else
{
    x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
    x2 = (-b - Math.Sqrt(delta)) / (2.0 * a);

    Console.WriteLine("X1 = " + x1.ToString("F5"));
    Console.WriteLine("X2 = " + x2.ToString("F5"));
}

// 
Console.ReadLine();



