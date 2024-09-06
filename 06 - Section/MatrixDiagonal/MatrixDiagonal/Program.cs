// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

//
string str = "Type a integer number(matrix length): ";
string str1 = "Type the numbers, split by space: ";
string str2 = "Main diagonal: ";
string str3 = "Negative number(s): ";
int count = 0;

Console.Write(str);
int n = Convert.ToInt16(Console.ReadLine());

int[,] matrix = new int[n, n];
//
for (int i = 0; i < n; i++)
{
    Console.WriteLine(str1);
    string[] numbers = Console.ReadLine().Split(' ');

    for (int j = 0; j < n; j++)
    {
        matrix[i, j] = Convert.ToInt16(numbers[j]);
    }
}

//
Console.WriteLine();

Console.WriteLine(str2);
for (int i = 0; i < n; i++)
{
    Console.Write(matrix[i,i] + " ");
}

Console.WriteLine();

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        if (matrix[i, j] < 0)
        {
            count++;
        }
    }
}

Console.WriteLine(str3 + count);

Console.ReadLine();