// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// Variables:
string str = "Type the employee number, working hours, value hour, slip by comma:";

//
Console.WriteLine(str);
string[] typedInfos = Console.ReadLine().Split(' ');

//
int employeeNumber = Convert.ToInt16(typedInfos[0]);
double workingHours = Convert.ToDouble(typedInfos[1]);
double valueHour = Convert.ToDouble(typedInfos[2]);

//
double salary = valueHour * workingHours;

//
Console.WriteLine("NUMBER = " + employeeNumber);
Console.WriteLine("SALARY = $" + salary.ToString("F2"));

Console.ReadLine();

