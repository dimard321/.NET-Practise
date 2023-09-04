using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Figures
{
    class Circle: IFigure
    {
        private double radius { get; init; }

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public double Area()
        {
            return Math.PI * radius * radius;
        }

        public double Perimeter()
        {
            return Math.PI * radius * 2;
        }
    }

    class Triangle: IFigure
    {
        private double a { get; init; }

        private double b { get; init; }

        private double c { get; init; }

        public Triangle(double a, double b, double c)
        {
            this.a = a;

            this.b = b;

            this.c = c;
        }

        public double Area()
        {
            var P = Perimeter();

            var p = P / 2;

            return Math.Sqrt(p * (p - a)*(p - b)*(p - c));
        }

        public double Perimeter()
        {
            var P = a + b + c; 
            
            return P;
        }
    }

    class Rectangle : IFigure
    {
        private double a { get; init; }

        private double b { get; init; }

        public Rectangle(double a, double b)
        {
            this.a = a;

            this.b = b;
        }

        public double Area()
        {
            return a * b;
        }

        public double Perimeter()
        {
            return (a + b) * 2;
        } 
    }

    class Square : IFigure
    {
        private double a { get; init; }

        public Square(double a)
        {
            this.a = a;
        }

        public double Area()
        {
            return a * a;
        }

        public double Perimeter()
        {
            return a  * 4;
        }
    }
}
