// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

string sourcePath = @"/Applications/Study/Udemy/05 - C# COMPLETO Programação Orientada a Objetos + Projetos/13 - Section 13/Files/file.txt";
string targetPath = @"/Applications/Study/Udemy/05 - C# COMPLETO Programação Orientada a Objetos + Projetos/13 - Section 13/Files/file2.txt";

// 1- File, FileInfo, FileRead, IOException:
// FileInfo? fileInfo = null;

// 2- FileStream and StreamReader:
// NOTE -> First is the FileStream associate to the file, next is the StreamReader associate to the FileStream;
// FileStream? fs = null;
// 3- File inclued the FileStream and StreamReader:
StreamReader? sr = null;

try
{
    /*fileInfo.CopyTo(targetPath);
    fileInfo = new FileInfo(sourcePath);
    string[] lines = File.ReadAllLines(sourcePath);
    foreach (string line in lines)
    {
        Console.WriteLine(line);
    } */


    //
    //fs = new FileStream(sourcePath, FileMode.Open);
    //sr = new StreamReader(fs);

    // OR:
    sr = File.OpenText(sourcePath);
    while (!sr.EndOfStream)
    {
        string? line = sr.ReadLine();
        Console.WriteLine(line);
    }
}
catch (IOException ex)
{
    Console.WriteLine($"An error occurred {ex.Message}");
}
finally
{
    if (sr != null) sr.Close();
    // if (fs != null) fs.Close();
}

Console.ReadLine();
