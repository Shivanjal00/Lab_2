using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_1
{
    abstract class Shape
    {
        public abstract double CalculateArea();
    }

    class Circle : Shape
    {
        public double radius;

        public Circle(Double r){ radius = r; }

        public override double CalculateArea()
        {
            return Math.PI * radius * radius;
        }
    }

    class Rectangle : Shape
    {
        public double Width;
        public double Height;

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public override double CalculateArea()
        {
            return Width * Height;
        }
    }


    internal class Program
    {
        static void Main(String[] args)
        {
            Circle cir = new Circle(7);
            Rectangle rectangle = new Rectangle(5,7);

            double circleArea = cir.CalculateArea();
            double rectangleArea = rectangle.CalculateArea();

            Console.WriteLine("Circle Area: "+circleArea);
            Console.WriteLine("Rectangle Area: "+rectangleArea);

        }
    }
}