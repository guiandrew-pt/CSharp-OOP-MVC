// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using CsvLambdaReview.Entities;

string source = "/Applications/Study/Udemy/05 - C# COMPLETO Programação Orientada a Objetos + Projetos/17 - Section 17/File/input.txt";

Console.Write("Enter full file path: ");
string? path = Console.ReadLine();

Console.Write("Enter salary: ");
double salary = double.Parse(Console.ReadLine());

Console.WriteLine("==================================");

List<Employee> employees = new List<Employee>();

try
{
    using (StreamReader sr = File.OpenText(path))
    {
        while (!sr.EndOfStream)
        {
            string[] fields = sr.ReadLine().Split(',');
            string name = fields[0].Trim();
            string email = fields[1].Trim();
            double salaryEmployee = double.Parse(fields[2]);

            employees.Add(new Employee(name, email, salaryEmployee));
        }
    }

    IEnumerable<string> salaryMoreThan = employees.Where(e => e.Salary > salary).OrderBy(e => e.Email).Select(e => e.Email);

    Console.WriteLine($"Email of people whose salary is more than {salary.ToString("F2")}");

    foreach (string email in salaryMoreThan)
    {
        Console.WriteLine(email);
    }

    double salaryPeopleNameStartM = employees.Where(e => e.Name[0] == 'M').Sum(p => p.Salary);
    Console.WriteLine($"Sum of salary of people whose name starts with 'M': {salaryPeopleNameStartM.ToString("F2")}");

    Console.ReadLine();
}
catch (IOException ex)
{
    Console.WriteLine($"An error ocurred: {ex.Message}");
}
