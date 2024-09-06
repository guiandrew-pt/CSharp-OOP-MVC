// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using Rectangle;

//
string str = "Type the height and the width:";
string heightStr = "Height: ";
string widthStr = "Width: ";

//
Console.WriteLine(str);
Console.Write(heightStr);
double height = double.Parse(Console.ReadLine());
Console.Write(widthStr);
double width = double.Parse(Console.ReadLine());

RectangleClass rectangleClass = new RectangleClass(height, width);

Console.WriteLine();

Console.WriteLine(rectangleClass.ToString());

Console.ReadLine();
