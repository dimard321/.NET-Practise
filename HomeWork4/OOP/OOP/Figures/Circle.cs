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
}
