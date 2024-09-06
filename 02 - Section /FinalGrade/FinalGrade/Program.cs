// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using FinalGrade;

//
Console.Write("Student Name: ");
string name = Console.ReadLine();
Console.WriteLine("Type the three grades:");
Console.Write("Grade 1: ");
double grade1 = double.Parse(Console.ReadLine());
Console.Write("Grade 2: ");
double grade2 = double.Parse(Console.ReadLine());
Console.Write("Grade 3: ");
double grade3 = double.Parse(Console.ReadLine());

Student student = new Student(name, grade1, grade2, grade3);

//
Console.WriteLine();

Console.WriteLine(student);

if (student.Approved())
{
    Console.WriteLine("Approved");
}
else
{
    Console.WriteLine("Reapproved");
    Console.WriteLine("Remaining " + student.Remaining() + " points");
}

Console.ReadLine();

