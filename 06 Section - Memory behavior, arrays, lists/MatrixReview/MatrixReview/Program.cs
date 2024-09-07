// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

double[,] mat = new double[2, 3];

Console.WriteLine(mat.Length);
Console.WriteLine(mat.Rank); // total of dimensions
Console.WriteLine(mat.GetLength(0)); // First "row"
Console.WriteLine(mat.GetLength(1)); // Second "row"

Console.ReadLine();
