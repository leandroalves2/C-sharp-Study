using Shape_Abstract.Entities;
using Shape_Abstract.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Shape_Abstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo ci  = CultureInfo.InvariantCulture;
            Console.Write("Enter the number of shapes: ");
            int n = int.Parse(Console.ReadLine());
            List<Shape> shapes = new List<Shape>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Shape #{i} data:");
                Console.Write("Rectangle or Circle (r/c)? ");
                char resp = char.Parse(Console.ReadLine().ToLower());
                switch (resp)
                {
                    case 'r':
                        Console.Write("Color (Black/Blue/Red): ");
                        Color color = (Color)Enum.Parse(typeof(Color), Console.ReadLine());
                        Console.Write("Width: ");
                        double width = double.Parse(Console.ReadLine(), ci);
                        Console.Write("Height: ");
                        double height = double.Parse(Console.ReadLine(), ci);
                        shapes.Add(new Rectangle(width, height, color));
                        break;
                    case 'c':
                        Console.Write("Color (Black/Blue/Red): ");
                        color = (Color)Enum.Parse(typeof(Color), Console.ReadLine());
                        Console.Write("Radius: ");
                        double radius = double.Parse(Console.ReadLine(), ci);
                        shapes.Add(new Circle(radius, color));
                        break;
                }
            }

            Console.WriteLine();
            Console.WriteLine("SHAPE AREAS:");
            foreach (Shape shape in shapes)
            {
                Console.WriteLine(shape.Area().ToString("F2", ci));
            }



        }
    }
}
