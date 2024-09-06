// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

string sourcePath = @"/Applications/Study/Udemy/05 - C# COMPLETO Programação Orientada a Objetos + Projetos/13 - Section 13/Files/file.txt";
string targetPath = @"/Applications/Study/Udemy/05 - C# COMPLETO Programação Orientada a Objetos + Projetos/13 - Section 13/Files/file2.txt";

try
{
    string[] lines = File.ReadAllLines(sourcePath);

    using (StreamWriter sw = File.AppendText(targetPath))
    {
        foreach (string line in lines)
        {
            sw.WriteLine(line.ToUpper());
        }
    }
}
catch (IOException ex)
{
    Console.WriteLine($"An error occurred {ex.Message}");
}

Console.ReadLine();
