// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

//
string str1 = "Type a integer number: ";
int fat = 1;

//
Console.Write(str1);
int n = Convert.ToInt16(Console.ReadLine());

//
for (int i = 1; i <= n; i++)
{
    fat *=  i;
}

Console.WriteLine(fat);

Console.ReadLine();