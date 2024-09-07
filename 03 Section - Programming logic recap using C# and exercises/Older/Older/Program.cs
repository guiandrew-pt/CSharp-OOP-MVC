// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

//
using Older;

internal class Program
{
    private static void Main(string[] args)
    {
        string str1 = "Type the data of the first person:";
        string str2 = "Type the data of the second person:";
        string str3 = "Older person is: ";
        string nameStr = "Name: ";
        string ageStr = "Age: ";
        Person person1;
        Person person2;

        //
        Console.WriteLine(str1);
        Console.Write(nameStr);
        string name = Console.ReadLine();
        Console.Write(ageStr);
        int age = Convert.ToInt16(Console.ReadLine());

        person1 = new Person(name, age);

        Console.WriteLine(str2);
        Console.Write(nameStr);
        name = Console.ReadLine();
        Console.Write(ageStr);
        age = Convert.ToInt16(Console.ReadLine());

        person2 = new Person(name, age);

        //
        if (IsOlder(person1.Age, person2.Age))
        {
            Console.WriteLine(str3 + person1.Name);
        }
        else
        {
            Console.WriteLine(str3 + person2.Name);
        }

        Console.ReadLine();
    }

    // Methods:
    public static bool IsOlder(int firstPersonAge, int secondPersonAge)
    {
        return firstPersonAge > secondPersonAge;
    }
}