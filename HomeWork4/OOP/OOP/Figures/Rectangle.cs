using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Figures
{
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
}
