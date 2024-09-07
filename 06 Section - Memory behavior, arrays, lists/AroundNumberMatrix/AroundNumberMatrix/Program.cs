// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//
string str = "Type two numbers(matrix length), slipt by space: ";
string str1 = "Type the numbers, slipt by space: ";
string str2 = "Type the position: ";

Console.Write(str);
string[] numbersStr = Console.ReadLine().Split(' ');

int m = Convert.ToInt16(numbersStr[0]);
int n = Convert.ToInt16(numbersStr[1]);

int[,] matrix = new int[m,n];

Console.WriteLine();

//
for (int i = 0; i < m; i++)
{
    Console.Write(str1);
    string[] numbers = Console.ReadLine().Split(' ');

    for (int j = 0; j < n; j++)
    {
        matrix[i, j] = Convert.ToInt16(numbers[j]);
    }
}

//
Console.WriteLine();

Console.Write(str2);
int positionX = Convert.ToInt16(Console.ReadLine());

Console.WriteLine();

//
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        if (matrix[i, j] == positionX)
        {
            Console.WriteLine("Position: " + i + "," + j + ":");
            if (j > 0)
            {
                Console.WriteLine("Left: " + matrix[i, j - 1]);
            }
            if (i > 0)
            {
                Console.WriteLine("Up: " + matrix[i - 1, j]);
            }
            if (j < n - 1)
            {
                Console.WriteLine("Right: " + matrix[i, j + 1]);
            }
            if (i < m - 1)
            {
                Console.WriteLine("Down: " + matrix[i + 1, j]);
            }
        }
    }
}

Console.ReadLine();