using Shape_Abstract.Entities.Enums;

namespace Shape_Abstract.Entities
{
    internal abstract class Shape
    {
        public Color Color { get; set; }
        public Shape() { }
        public Shape(Color color) { Color = color;  }

        public abstract double Area();

    }
}
