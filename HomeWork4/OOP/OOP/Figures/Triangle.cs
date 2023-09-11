using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Figures
{
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

            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
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
}
