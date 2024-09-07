// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

//
string str1 = "Type a integer number(amount): ";
string str2 = "Type a integer number(intervalo?): ";
int in_ = 0;
int out_ = 0;
int x = 0;

//
Console.Write(str1);
int n = Convert.ToInt16(Console.ReadLine());

//
for (int i = 0; i < n; i++)
{
    Console.Write(str2);
    x = Convert.ToInt16(Console.ReadLine());

    if (x >= 10 && x <= 20)
    {
        in_ += 1;
    }
    else
    {
        out_ += 1;
    }
}

Console.WriteLine(in_ + " in");
Console.WriteLine(out_ + " out");

Console.ReadLine();