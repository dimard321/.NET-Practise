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
        private double A { get; init; }

        /// <summary>
        /// Приватное поле для хранения длины второй стороны треугольника.
        /// </summary>
        private double B { get; init; }

        /// <summary>
        /// Приватное поле для хранения длины третьей стороны треугольника.
        /// </summary>
        private double C { get; init; }

        /// <summary>
        /// Конструктор класса Triangle, принимающий длины трех сторон треугольника и инициализирующий поля.
        /// </summary>
        /// <param name="a">Длина первой стороны.</param>
        /// <param name="b">Длина второй стороны.</param>
        /// <param name="c">Длина третьей стороны.</param>
        public Triangle(double a, double b, double c)
        {
            A = a;

            B = b;

            C = c;
        }

        ///<inheritdoc/>
        public double Area()
        {
            var perimeter = Perimeter();

            var halfMeter = perimeter / 2;

            return Math.Sqrt(halfMeter * (halfMeter - A) * (halfMeter - B) * (halfMeter - C));
        }

        ///<inheritdoc/>
        public double Perimeter()
        {
            if (A > 0 && B > 0 && C > 0)
            {
                return A + B + C;
            }
            else
            {
                throw new IOException("Введите величину, больше 0");
            }
        }
    }
}
