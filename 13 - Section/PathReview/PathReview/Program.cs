// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

string sourcePath = @"/Applications/Study/Udemy/05 - C# COMPLETO Programação Orientada a Objetos + Projetos/13 - Section 13/Files/file.txt";

Console.WriteLine($"DirectorySeparatorChar: {Path.DirectorySeparatorChar}");
Console.WriteLine($"PathSeparator: {Path.PathSeparator}");
Console.WriteLine($"GetDirectoryName: {Path.GetDirectoryName(sourcePath)}");
Console.WriteLine($"GetFileName: {Path.GetFileName(sourcePath)}");
Console.WriteLine($"GetFileNameWithoutExtension: {Path.GetFileNameWithoutExtension(sourcePath)}");
Console.WriteLine($"GetExtension: {Path.GetExtension(sourcePath)}");
Console.WriteLine($"GetFullPath: {Path.GetFullPath(sourcePath)}");
Console.WriteLine($"GetTempPath: {Path.GetTempPath()}");

Console.ReadLine();