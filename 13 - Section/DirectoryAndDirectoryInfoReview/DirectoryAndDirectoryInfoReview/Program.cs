// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

string sourcePath = @"/Applications/Study/Udemy/05 - C# COMPLETO Programação Orientada a Objetos + Projetos/13 - Section 13/MyFolder";
// string targetPath = @"/Applications/Study/Udemy/05 - C# COMPLETO Programação Orientada a Objetos + Projetos/13 - Section 13/Files/file2.txt";

try
{
    // Will List all folders inside MyFolder:
    IEnumerable<string> folders = Directory.EnumerateDirectories(sourcePath, "*.*", SearchOption.AllDirectories);
    Console.WriteLine("Folders:");
    foreach (string str in folders)
    {
        Console.WriteLine(str);
    }

    Console.WriteLine();
    Console.WriteLine("=============");
    Console.WriteLine();

    // Will List all the files inside MyFolder, sub-folders included:
    IEnumerable<string> files = Directory.EnumerateFiles(sourcePath, "*.*", SearchOption.AllDirectories);
    Console.WriteLine("Files:");
    foreach (string str in files)
    {
        Console.WriteLine(str);
    }

    Console.WriteLine();
    Console.WriteLine("=============");
    Console.WriteLine();

    // Will create a new folder:
    Directory.CreateDirectory(sourcePath + "/NewFolder");
}
catch (IOException ex)
{
    Console.WriteLine($"An error occurred {ex.Message}");
}

Console.ReadLine();