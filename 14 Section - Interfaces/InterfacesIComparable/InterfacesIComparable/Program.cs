// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using InterfacesIComparable.Entities;

//
// string path = @"/Applications/Study/Udemy/05 - C# COMPLETO Programação Orientada a Objetos + Projetos/13 - Section 13/Files/in.txt";
string path2 = @"/Applications/Study/Udemy/05 - C# COMPLETO Programação Orientada a Objetos + Projetos/13 - Section 13/Files/in2.txt";

try
{
    using (StreamReader sr = File.OpenText(path2))
    {
        List<Employee> list = new List<Employee>();

        while (!sr.EndOfStream)
        {
            list.Add(new Employee(sr.ReadLine()));
        }

        list.Sort();

        foreach (Employee employee in list)
        {
            Console.WriteLine(employee);
        }
    }
}
catch (IOException ex)
{
    Console.WriteLine($"An error occurred: {ex.Message}");
}

Console.ReadLine();