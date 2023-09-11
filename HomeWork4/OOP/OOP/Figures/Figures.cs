using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Figures
{
    /// <summary>
    /// Класс для круга.
    /// </summary>
    class Circle : IFigure
    {
        /// <summary>
        /// Приватное поле для хранения радиуса круга.
        /// </summary>
        private double radius { get; init; }

        /// <summary>
        /// Конструктор класса Circle, принимающий радиус и инициализирующий поле.
        /// </summary>
        /// <param name="radius">Радиус круга.</param>
        public Circle(double radius)
        {
            this.radius = radius;
        }

        /// <summary>
        /// Метод для вычисления площади круга.
        /// </summary>
        /// <returns>Площадь круга.</returns>
        public double Area()
        {
            return Math.PI * radius * radius;
        }

        /// <summary>
        /// Метод для вычисления периметра круга.
        /// </summary>
        /// <returns>Периметр круга.</returns>
        public double Perimeter()
        {
            return Math.PI * radius * 2;
        }
    }

    /// <summary>
    /// Класс для треугольника.
    /// </summary>
    class Triangle : IFigure
    {
        /// <summary>
        /// Приватное поле для хранения длины первой стороны треугольника.
        /// </summary>
        private double a { get; init; }

        /// <summary>
        /// Приватное поле для хранения длины второй стороны треугольника.
        /// </summary>
        private double b { get; init; }

        /// <summary>
        /// Приватное поле для хранения длины третьей стороны треугольника.
        /// </summary>
        private double c { get; init; }

        /// <summary>
        /// Конструктор класса Triangle, принимающий длины трех сторон треугольника и инициализирующий поля.
        /// </summary>
        /// <param name="a">Длина первой стороны.</param>
        /// <param name="b">Длина второй стороны.</param>
        /// <param name="c">Длина третьей стороны.</param>
        public Triangle(double a, double b, double c)
        {
            this.a = a;

            this.b = b;

            this.c = c;
        }

        /// <summary>
        /// Метод для вычисления площади треугольника.
        /// </summary>
        /// <returns>Площадь треугольника.</returns>
        public double Area()
        {
            var P = Perimeter();

            var p = P / 2;

            return Math.Sqrt(p * (p - a)*(p - b)*(p - c));
        }

        /// <summary>
        /// Метод для вычисления периметра треугольника.
        /// </summary>
        /// <returns>Периметр треугольника.</returns>
        public double Perimeter()
        {
            var P = a + b + c; 
            
            return P;
        }
    }

    /// <summary>
    /// Класс для прямоугольника.
    /// </summary>
    class Rectangle : IFigure
    {
        /// <summary>
        /// Приватное поле для хранения длины первой стороны прямоугольника.
        /// </summary>
        private double a { get; init; }

        /// <summary>
        /// Приватное поле для хранения длины второй стороны прямоугольника.
        /// </summary>
        private double b { get; init; }

        /// <summary>
        /// Конструктор класса Rectangle, принимающий длины двух сторон прямоугольника и инициализирующий поля.
        /// </summary>
        /// <param name="a">Длина первой стороны.</param>
        /// <param name="b">Длина второй стороны.</param>
        public Rectangle(double a, double b)
        {
            this.a = a;

            this.b = b;
        }

        /// <summary>
        /// Метод для вычисления площади прямоугольника.
        /// </summary>
        /// <returns>Площадь прямоугольника.</returns>
        public double Area()
        {
            return a * b;
        }

        /// <summary>
        /// Метод для вычисления периметра прямоугольника.
        /// </summary>
        /// <returns>Периметр прямоугольника.</returns>
        public double Perimeter()
        {
            return (a + b) * 2;
        } 
    }

    /// <summary>
    /// Класс для квадрата.
    /// </summary>
    class Square : IFigure
    {
        /// <summary>
        /// Приватное поле для хранения длины стороны квадрата.
        /// </summary>
        private double a { get; init; }

        /// <summary>
        /// Конструктор класса Square, принимающий длину стороны квадрата и инициализирующий поле.
        /// </summary>
        /// <param name="a">Длина стороны квадрата.</param>
        public Square(double a)
        {
            this.a = a;
        }

        /// <summary>
        /// Метод для вычисления площади квадрата.
        /// </summary>
        /// <returns>Площадь квадрата.</returns>
        public double Area()
        {
            return a * a;
        }

        /// <summary>
        /// Метод для вычисления периметра квадрата.
        /// </summary>
        /// <returns>Периметр квадрата.</returns>
        public double Perimeter()
        {
            return a  * 4;
        }
    }
}
