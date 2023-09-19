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
        private double Radius { get; init; }

        /// <summary>
        /// Конструктор класса Circle, принимающий радиус и инициализирующий поле.
        /// </summary>
        /// <param name="radius">Радиус круга.</param>
        public Circle(double radius)
        {
            Radius = radius;
        }

        ///<inheritdoc/>
        public double Area()
        {
            if (Radius > 0)
            {
                return Math.PI * Radius * Radius;
            }
            else
            {
                throw new IOException("Введите величину, больше 0");
            }
           
        }

        ///<inheritdoc/>
        public double Perimeter()
        {
            if(Radius > 0)
            {
                return Math.PI * Radius * 2;
            }
            else
            {
                throw new IOException("Введите величину, больше 0");
            }
            
        }
    }
}
