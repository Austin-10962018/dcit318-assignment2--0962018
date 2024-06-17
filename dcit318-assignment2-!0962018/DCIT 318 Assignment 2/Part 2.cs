using System;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{

    abstract class Shape
    {
        public abstract double GetArea();
    }

    class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double GetArea()
        {
            return Math.PI * Radius * Radius;
        }
    }

    class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public override double GetArea()
        {
            return Width * Height;
        }
    }

    class Program
    {
        static void Main()
        {
            // Get user input for Circle
            Console.WriteLine("Enter the radius of the circle:");
            double circleRadius = Convert.ToDouble(Console.ReadLine());
            Circle circle = new Circle(circleRadius);
            Console.WriteLine($"Circle area: {circle.GetArea()}");

            // Get user input for Rectangle
            Console.WriteLine("Enter the width of the rectangle:");
            double rectangleWidth = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the height of the rectangle:");
            double rectangleHeight = Convert.ToDouble(Console.ReadLine());
            Rectangle rectangle = new Rectangle(rectangleWidth, rectangleHeight);
            Console.WriteLine($"Rectangle area: {rectangle.GetArea()}");
        }
    }
}
