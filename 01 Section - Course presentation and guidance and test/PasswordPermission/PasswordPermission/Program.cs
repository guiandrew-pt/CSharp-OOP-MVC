// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


// Variables:
string str = "Type the correct password(number, four digits):";
string invalidPassword = "Invalid Password";
string accessPassword = "Access Allowed";
int correctPass = 2002;

//
int aux = 0;
while (aux != correctPass)
{
    Console.WriteLine(str);
    int typed = Convert.ToInt16(Console.ReadLine());
    if (typed == correctPass)
    {
        Console.WriteLine(accessPassword);
        aux = typed;
    }
    else
    {
        Console.WriteLine(invalidPassword);
    }
}

Console.ReadLine();

