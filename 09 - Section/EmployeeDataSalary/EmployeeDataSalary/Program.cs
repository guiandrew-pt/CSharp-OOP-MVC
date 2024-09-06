// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//
using System.Globalization;
using EmployeeDataSalary.Entities;
using EmployeeDataSalary.Entities.Enums;

Console.Write("Enter department's name: ");
string departmentName = Console.ReadLine();

Console.WriteLine("Enter worker data:");

Console.Write("Name: ");
string employeeName = Console.ReadLine();

Console.Write("Level (Junior/MidLevel/Senior): ");
WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());

Console.Write("Base salary: ");
double baseSalary = double.Parse(Console.ReadLine());

Department department = new Department(departmentName);
Worker worker = new Worker(employeeName, level, baseSalary, department);

Console.Write("How many contracts to this worker? ");
int numberContract = Convert.ToInt16(Console.ReadLine());

for (int i = 0; i < numberContract; i++)
{
    Console.WriteLine();

    Console.Write($"Enter #{i + 1} contract data: ");

    Console.Write("Date (DD/MM/YYYY): ");
    DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

    Console.Write("Value per hour: ");
    double valuePerHour = double.Parse(Console.ReadLine());

    Console.Write("Duration (hours): ");
    int hours = Convert.ToInt16(Console.ReadLine());

    HourContract contract = new HourContract(date, valuePerHour, hours);

    worker.AddContract(contract);
}

Console.WriteLine();

Console.Write("Enter month and year to calculate income (MM/YYYY): ");
string monthAndYear = Console.ReadLine();

int month = Convert.ToInt16(monthAndYear.Substring(0, 2)); // Will give the month
int year = Convert.ToInt16(monthAndYear.Substring(3)); // Will give the year

Console.WriteLine("Name: " + worker.Name);
Console.WriteLine("Department: " + worker.Department.Name);
Console.WriteLine($"Income for {monthAndYear}: ${worker.Income(year, month)}");

Console.ReadLine();