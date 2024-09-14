// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// 
using AbstractMethodsReview.Entities;
using AbstractMethodsReview.Entities.Enums;

//
List<Shape> shapes = new List<Shape>();

Console.Write("Enter the number od shapes: ");
int numberOfShapes = Convert.ToInt16(Console.ReadLine());

for (int i = 1; i <= numberOfShapes; i++)
{
    Console.WriteLine($"Shape #{i} data:");
    Console.Write("Rectangle or Circle (r/c)? ");
    char answer = char.Parse(Console.ReadLine());

    Console.Write("Color (Black/Blue/Red): ");
    Color color = Enum.Parse<Color>(Console.ReadLine());

    if (answer == 'r')
    {
        Console.Write("Width: ");
        double width = double.Parse(Console.ReadLine());

        Console.Write("Height: ");
        double height = double.Parse(Console.ReadLine());

        shapes.Add(new Rectangle(color, width, height));
    }
    else
    {
        Console.Write("Radius: ");
        double radius = double.Parse(Console.ReadLine());

        shapes.Add(new Circle(color, radius));
    }
}

Console.WriteLine();
Console.WriteLine("SHAPES AREAS:");

foreach (Shape shape in shapes)
{
    Console.WriteLine(shape.Area().ToString("F2"));
}

Console.ReadLine();