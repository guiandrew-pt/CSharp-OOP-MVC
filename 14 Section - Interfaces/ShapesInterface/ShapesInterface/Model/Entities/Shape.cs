using ShapesInterface.Model.Enums;

namespace ShapesInterface.Model.Entities
{
	public abstract class Shape
	{
		public Color Color { get; set; }

		public abstract double Area();
	}
}

