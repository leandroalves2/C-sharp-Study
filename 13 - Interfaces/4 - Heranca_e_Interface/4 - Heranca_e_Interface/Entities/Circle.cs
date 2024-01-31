using _4___Heranca_e_Interface.Enuns;
using System;
using System.Globalization;

namespace _4___Heranca_e_Interface.Entities
{
    internal class Circle : AbstractShape
    {
        public double Radius { get; set; }
        public Colors Color { get; set; }

        public Circle(double radius, Colors color)
        {
            Radius = radius;
            Color = color;
        }

        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }

        public override string ToString()
        {
            return "Circle color = "
                + Color
                + ", radius = "
                + Radius.ToString("F2", CultureInfo.InvariantCulture)
                + ", area = "
                + Area().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
