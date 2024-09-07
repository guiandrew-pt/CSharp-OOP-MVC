// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using Hostel;

//
Student[] students = new Student[9];

Console.Write("How many rooms will be rented? ");
int n = Convert.ToInt16(Console.ReadLine());
Console.WriteLine();

//
for (int i = 0; i < n; i++)
{
    Console.WriteLine("Rent #" + (i + 1));
    Console.Write("Name: ");
    string name = Console.ReadLine();

    Console.Write("Email: ");
    string email = Console.ReadLine();

    Console.Write("Room number: ");
    int number = Convert.ToInt16(Console.ReadLine());

    students[number] = new Student(name, email);

    Console.WriteLine();
}

Console.WriteLine("Busy Rooms:");

for (int i = 0; i < students.Length; i++)
{
    if (students[i] != null)
    {
        Console.WriteLine(i + ": " + students[i]);
    }
}

Console.ReadLine();
