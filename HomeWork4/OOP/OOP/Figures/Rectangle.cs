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
        private double Length { get; init; }

        /// <summary>
        /// Приватное поле для хранения длины второй стороны прямоугольника.
        /// </summary>
        private double Width { get; init; }

        /// <summary>
        /// Конструктор класса Rectangle, принимающий длины двух сторон прямоугольника и инициализирующий поля.
        /// </summary>
        /// <param name="length">Длина первой стороны.</param>
        /// <param name="width">Длина второй стороны.</param>
        public Rectangle(double length, double width)
        {
            Length = length;

            Width = width;
        }

        ///<inheritdoc/>
        public double Area()
        {
            if(Length > 0 && Width>0) 
            {

                return Length * Width;
            }
            else
            {
                throw new IOException("Введите величину, больше 0");
            }
        }

        ///<inheritdoc/>
        public double Perimeter()
        {
            if (Length > 0 && Width > 0)
            {
                return (Length + Width) * 2;
            }
            else
            {
                throw new IOException("Введите величину, больше 0");
            }

        }
    }
}
