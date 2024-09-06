// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// Variables:
string str = "Type a decimal number(2 decimal number):";
double incomeTax = 0.0;

//
Console.WriteLine(str);
double salary = double.Parse(Console.ReadLine());

//
if (salary <= 2000.00)
{
    incomeTax = 0.0;
}
else if (salary <= 3000.00)
{
    incomeTax = (salary - 2000.0) * 0.08;
}
else if (salary <= 4500.00)
{
    incomeTax = (salary - 3000.0) * 0.18 + 1000.0 * 0.08;
}
else
{
    incomeTax = (salary - 4500.0) * 0.28 + 1500.0 * 0.18 + 1000.0 * 0.08;
}

if (incomeTax == 0.0)
{
    Console.WriteLine("Tax free");
}
else
{
    Console.WriteLine("$" + incomeTax.ToString("F2"));
}

Console.ReadLine();