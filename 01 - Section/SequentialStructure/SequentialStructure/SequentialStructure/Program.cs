// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// Item 1 values
string str1 = "Please enter the code, the amount, and the value of the first item, split by the space.";

Console.WriteLine(str1);

string[] itemArr1 = Console.ReadLine().Split(' ');

// Item 2 values
string str2 = "Please enter the code, the amount, and the value of the second item, split by the space.";

Console.WriteLine(str2);

string[] itemArr2 = Console.ReadLine().Split(' ');

// Item 1 math
int item1Amount = Convert.ToInt16(itemArr1[1]);
double item1Value = Convert.ToDouble(itemArr1[2]);
double item1Total = item1Amount * item1Value;

// Item 2
int item2Amount = Convert.ToInt16(itemArr2[1]);
double item2Value = Convert.ToDouble(itemArr2[2]);
double item2Total = item2Amount * item2Value;

// Total
double total = item1Total + item2Total;

Console.WriteLine("The value to pay is: $" + total.ToString("F2"));

Console.Read();
