// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using SaleItems.Entities;

//
// string sourcePath = @"/Applications/Study/Udemy/05 - C# COMPLETO Programação Orientada a Objetos + Projetos/13 - Section 13/Exercise/items.csv";
// string targetPath = @"/Applications/Study/Udemy/05 - C# COMPLETO Programação Orientada a Objetos + Projetos/13 - Section 13/Exercise/summary.csv";

Console.Write("Type the full path: ");
string? sourcePath = Console.ReadLine();

try
{
    string[] lines = File.ReadAllLines(sourcePath);

    string? sourceFolderPath = Path.GetDirectoryName(sourcePath);
    string targetFolderPath = $"{sourceFolderPath}/out";
    string targetFilePath = $"{targetFolderPath}/summary.csv";

    Directory.CreateDirectory(targetFolderPath);

    using (StreamWriter sw = File.AppendText(targetFilePath))
    {
        foreach (string line in lines)
        {
            string[] values = line.Split(',');
            string productName = values[0];
            double price = double.Parse(values[1]);
            int amount = Convert.ToInt16(values[2]);

            Product product = new Product(productName, price, amount);

            sw.WriteLine($"{product}");
        }
    }
}
catch (IOException ex)
{
    Console.WriteLine($"An error occurred {ex.Message}");
}

Console.ReadLine();