using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._2025
{
    internal class Program
    {
        public abstract class Shape
        {
            public abstract double GetArea();
            public abstract double GetPerimeter();
        }
        public class Rectangle : Shape
        {
            public double width { get; set; }
            public double heigth { get; set; }
            public Rectangle(double width, double heigth)
            {
                this.width = width;
                this.heigth = heigth;
            }
            public override double GetArea()
            {
                Console.WriteLine(width * heigth);
                return width * heigth;
            }
            public override double GetPerimeter()
            {
                Console.WriteLine(2 * (width + heigth));
                return 2 * (width + heigth);
            }
        }
        public class Circle : Shape
        {
            public double radius { get; set; }
            public Circle(double radius)
            {
                this.radius = radius;
            }
            public override double GetArea()
            {
                Console.WriteLine(Math.PI * radius * radius);
                return Math.PI * radius * radius;
            }
            public override double GetPerimeter()
            {
                Console.WriteLine(2 * Math.PI * radius);
                return 2 * Math.PI * radius;             
            }
            public double GetDiametr()
            {
                Console.WriteLine(2 * radius);
                return 2 * radius;
            }
        }
        public class Triangle : Shape
        {
            public double s1 { get; set; }
            public double s2 { get; set; }
            public double base3 { get; set; }
            public double hight { get; set; }
            public Triangle(double s1, double s2, double base3, double hight)
            {
                this.s1 = s1;
                this.s2 = s2;
                this.base3 = base3;
                this.hight = hight;
            }

            public override double GetArea()
            {
                Console.WriteLine(0.5 * hight * base3);
                return 0.5 * hight * base3;
            }
            public override double GetPerimeter()
            {
                Console.WriteLine(s1 + s2 + base3);
                return s1 + s2 + base3;
            }
        }


        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>
            {
                new Rectangle(3, 4),
                new Circle(8),
                new Rectangle(9, 8),
                new Triangle(1, 2, 4, 3)
            };
            foreach (var shape in shapes)
            {
                shape.GetArea();
                shape.GetPerimeter();
            }
        }
    }
}
