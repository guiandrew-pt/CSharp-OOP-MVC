// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// Variables:
string str = "Type the code and the amount of the item you want, split by the space.";
int itemCod = 0;
int itemAmount = 0;
double itemValue = 0.0;

/* 
 Code      Specification       Price
    1       Hotdog              $4.00
    2       X-Salad             $4.50
    3       X-Bacon             $5.00
    4       Simple Toast        $2.00
    5       Soft Drink          $1.50
 */

//
Console.WriteLine(str);
string[] typed = Console.ReadLine().Split(" ");
itemCod = Convert.ToUInt16(typed[0]);
itemAmount = Convert.ToUInt16(typed[1]);

if (itemCod == 1)
{
    itemValue = 4.00;
}
else if (itemCod == 2)
{
    itemValue = 4.50;
}
else if (itemCod == 3)
{
    itemValue = 5.00;
}
else if (itemCod == 4)
{
    itemValue = 2.00;
}
else 
{
    itemValue = 1.50;
}

//
double totalToPay = itemValue * itemAmount;

Console.WriteLine("Total: $" + totalToPay.ToString("F2"));

Console.ReadLine();