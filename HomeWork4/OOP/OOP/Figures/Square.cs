using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Figures
{
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
            return a * 4;
        }
    }
}
