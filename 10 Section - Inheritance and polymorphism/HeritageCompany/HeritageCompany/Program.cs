// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using HeritageCompany.Entities;

//
List<Employee> employees = new List<Employee>();


Console.Write("Enter the number of employees: ");
int employeesNumbers = Convert.ToInt16(Console.ReadLine());

for (int i = 0; i < employeesNumbers; i++)
{
    Console.WriteLine($"Employee #{i + 1} data:");
    Console.Write("Outsourced (y/n)? ");
    char answer = char.Parse(Console.ReadLine());

    Console.Write("Name: ");
    string name = Console.ReadLine();

    Console.Write("Hours: ");
    int hours = Convert.ToInt16(Console.ReadLine());

    Console.Write("Value per hour: ");
    double valuePerHour = double.Parse(Console.ReadLine());

    if (answer == 'y')
    {
        Console.Write("Additional charge: ");
        double additionalCharge = double.Parse(Console.ReadLine());

        employees.Add(new OutsourcedEmployee(name, hours, valuePerHour, additionalCharge));
    }
    else
    {
        employees.Add(new Employee(name, hours, valuePerHour));
    }
}

Console.WriteLine();
Console.WriteLine("PAYMENTS:");

foreach (Employee employee in employees)
{
    Console.WriteLine(employee.Name + " - $" + employee.Payment().ToString("F2"));
}

Console.ReadLine();
