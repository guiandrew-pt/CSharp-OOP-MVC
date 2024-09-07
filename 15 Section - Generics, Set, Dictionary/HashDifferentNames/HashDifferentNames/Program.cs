// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using HashDifferentNames.Entities;

//
// string source = "/Applications/Study/Udemy/05 - C# COMPLETO Programação Orientada a Objetos + Projetos/15 - Section 15/File/text.txt";

//
HashSet<LogRecord> logRecords = new HashSet<LogRecord>();

Console.Write("Enter file full path: ");
string? path = Console.ReadLine();

Console.WriteLine();

try
{
    using (StreamReader sr = File.OpenText(path))
    {
        while (!sr.EndOfStream)
        {
            string[] line = sr.ReadLine().Split(' ');
            string name = line[0];
            DateTime instant = DateTime.Parse(line[1]);
            logRecords.Add(new LogRecord { Username = name, Instant = instant });
        }

        Console.WriteLine($"Total users: {logRecords.Count}");
    }
}
catch (IOException ex)
{
    Console.WriteLine(ex.Message);
}







Console.ReadLine();