// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

string sourcePath = @"/Applications/Study/Udemy/05 - C# COMPLETO Programação Orientada a Objetos + Projetos/13 - Section 13/Files/file.txt";
// string targetPath = @"/Applications/Study/Udemy/05 - C# COMPLETO Programação Orientada a Objetos + Projetos/13 - Section 13/Files/file2.txt";

try
{
    /* using (FileStream fs = new FileStream(sourcePath, FileMode.Open))
    {
        using (StreamReader sr = new StreamReader(fs))
        {
            while (!sr.EndOfStream)
            {
                string? line = sr.ReadLine();
                Console.WriteLine(line);
            }
        }
    } */

    // OR:
    using (StreamReader sr = File.OpenText(sourcePath))
    {
        while (!sr.EndOfStream)
        {
            string? line = sr.ReadLine();
            Console.WriteLine(line);
        }
    }
}
catch (IOException ex)
{
    Console.WriteLine($"An error occured {ex.Message}!");
}

Console.ReadLine();
