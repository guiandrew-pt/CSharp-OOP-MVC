// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using ChangeEmployeeData;

//
string nameStr = "Name: ";
string salaryStr = "Salary: ";
string taxStr = "Tax: ";

//
Console.Write(nameStr);
string name = Console.ReadLine();
Console.Write(salaryStr);
double salary = double.Parse(Console.ReadLine());
Console.Write(taxStr);
double tax = double.Parse(Console.ReadLine());

Employee employee = new Employee(name, salary, tax);

//
Console.Write("Employee: " + employee);

Console.WriteLine();
Console.Write("Type the amount to increase the salary: ");
tax = double.Parse(Console.ReadLine());

employee.IncreaseSalary(tax);

Console.WriteLine();
Console.Write("Data updated: " + employee);

Console.ReadLine();