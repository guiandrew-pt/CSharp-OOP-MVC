using AbstractMethodsReview.Entities.Enums;

namespace AbstractMethodsReview.Entities
{
	public class Rectangle : Shape
	{
		public double Width { get; set; }
		public double Height { get; set; }

        public Rectangle(Color color, double width, double height) : base(color)
        {
            Width = width;
            Height = height;
        }

        override public double Area()
        {
            return Width * Height;
        }
    }
}

