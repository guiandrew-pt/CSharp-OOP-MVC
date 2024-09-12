using System;
namespace Rectangle
{
	public class RectangleClass
	{
		//Properties:
		public double Width { get; set; }
        public double Height { get; set; }

        // Constructor:
        public RectangleClass(double width, double height)
		{
            Width = width;
            Height = height;
		}

		// Methods:
		public double Area()
		{
			return Width * Height;
		}

		public double Perimeter()
		{
            return 2 * (Width + Height);
        }

		public double Diagonal()
		{
			return Math.Sqrt(Width * Width + Height * Height);
		}

        public override string ToString()
        {
			return "Area = "
				+ Area().ToString("F2")
                + "\nPerimeter = "
                + Perimeter().ToString("F2")
                + "\nDiagonal = "
                + Diagonal().ToString("F2");
        }
    }
}

