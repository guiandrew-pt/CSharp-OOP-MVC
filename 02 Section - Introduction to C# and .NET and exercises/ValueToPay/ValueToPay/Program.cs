// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// Variables:
string str1 = "Type the item 1 number, amount, value, split by comma:";
string str2 = "Type the item 2 number, amount, value, split by comma:";

//
Console.WriteLine(str1);
string[] item1 = Console.ReadLine().Split(' ');
Console.WriteLine(str2);
string[] item2 = Console.ReadLine().Split(' ');

// Item 1
int item1Cod = Convert.ToInt16(item1[0]);
int item1Amount = Convert.ToInt16(item1[1]);
double item1Value = Convert.ToDouble(item1[2]);

// Item 2
int item2Cod = Convert.ToInt16(item2[0]);
int item2Amount = Convert.ToInt16(item2[1]);
double item2Value = Convert.ToDouble(item2[2]);

//
double valueToPay = (item1Value * item1Amount) + (item2Value * item2Amount);

//
Console.WriteLine("Value to pay: $" + valueToPay.ToString("F2"));
Console.ReadLine();