using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Figures
{
    /// <summary>
    /// Интерфейс IFigure определяет общие методы для всех геометрических фигур.
    /// </summary>
    public interface IFigure
    {
        /// <summary>
        /// Метод для вычисления площади фигуры.
        /// </summary>
        /// <returns>Площадь фигуры.</returns>
        public double Area();

        /// <summary>
        /// Метод для вычисления периметра фигуры.
        /// </summary>
        /// <returns>Периметр фигуры.</returns>
        public double Perimeter();
    }
}
