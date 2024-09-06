// Console.WriteLine("Hello, World!");

using AverageSalary;

internal class Program
{
    private static void Main(string[] args)
    {
        //
        string str1 = "Type the data of the first employee:";
        string str2 = "Type the data of the second employee:";
        string nameStr = "Name: ";
        string salaryStr = "Salary: ";
        Employee employee1;
        Employee employee2;

        //
        Console.WriteLine(str1);
        Console.Write(nameStr);
        string name = Console.ReadLine();
        Console.Write(salaryStr);
        double salary = double.Parse(Console.ReadLine());

        employee1 = new Employee(name, salary);

        Console.WriteLine(str2);
        Console.Write(nameStr);
        name = Console.ReadLine();
        Console.Write(salaryStr);
        salary = double.Parse(Console.ReadLine());

        employee2 = new Employee(name, salary);

        //
        double average = AverageSalary(employee1.Salary, employee2.Salary);

        Console.WriteLine("Average Salary: " + average.ToString("F2"));

        Console.ReadLine();
    }

    // Methods:
    public static double AverageSalary(double salary1, double salary2)
    {
        return (salary1 + salary2) / 2.0;
    }
}