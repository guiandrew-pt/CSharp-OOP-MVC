using ShapesInterface.Model.Entities.Interfaces;
using ShapesInterface.Model.Enums;

namespace ShapesInterface.Model.Entities
{
    public abstract class AbstractShape : IShape
    {
        public Color Color { get; set; }

        public abstract double Area();
    }
}

