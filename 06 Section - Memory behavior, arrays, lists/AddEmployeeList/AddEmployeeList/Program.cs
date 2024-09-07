// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using AddEmployeeList;

//
List<Employee> employees = new List<Employee>();
string str = "How many employees will be registered? ";
string str1 = "Enter the employee id that will have the salary increase: ";
string str2 = "Enter the percentage: ";
string str3 = "Update list of employees:";
int id = 0;

Console.Write(str);
int n = Convert.ToInt16(Console.ReadLine());

// 
for (int i = 1; i <= n; i++)
{
    Console.WriteLine();

    Console.WriteLine("Employee #" + i);
    Console.Write("Id: ");
    id = Convert.ToInt16(Console.ReadLine());

    Console.Write("Name: ");
    string name = Console.ReadLine();

    Console.Write("Salary: ");
    double salary = double.Parse(Console.ReadLine());

    //
    employees.Add(new Employee(id, name, salary));
}

Console.WriteLine();

//
Console.Write(str1);
id = Convert.ToInt16(Console.ReadLine());

// Check if exist an employee with this id
Employee employee = employees.Find(x => x.Id == id);
if (employee != null)
{
    Console.Write(str2);
    double percentage = double.Parse(Console.ReadLine());
    employee.IncreaseSalary(percentage);
}
else
{
    Console.WriteLine("The employee with this id does not exist!");
}

//
Console.WriteLine();

Console.WriteLine(str3);
foreach (Employee employee1 in employees)
{
    Console.WriteLine(employee1);
}

Console.ReadLine();











