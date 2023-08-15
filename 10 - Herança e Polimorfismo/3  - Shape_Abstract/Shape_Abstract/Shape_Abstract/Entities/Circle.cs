using Shape_Abstract.Entities.Enums;

namespace Shape_Abstract.Entities
{
    internal class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle() { }
        public Circle(double radius, Color color) 
            : base(color)
        { 
            Radius = radius;        
        }

        public override double Area()
        {
            return 3.14159 * (Radius * Radius);
        }

    }
}
