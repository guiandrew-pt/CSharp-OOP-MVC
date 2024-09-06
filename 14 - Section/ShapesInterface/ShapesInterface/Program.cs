// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using ShapesInterface.Model.Entities;
using ShapesInterface.Model.Entities.Interfaces;
using ShapesInterface.Model.Enums;

//
IShape shapeCircle = new Circle() { Radius = 2.0, Color = Color.White};
IShape shapeRectangle = new Rectangle() { Width = 3.5, Height = 4.2, Color = Color.Black};

Console.WriteLine(shapeCircle);
Console.WriteLine(shapeRectangle);

Console.ReadLine();

