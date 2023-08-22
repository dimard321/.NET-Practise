using System.Runtime.InteropServices;

namespace RectangleHelper
{
    /// <summary>
    /// Данный класс выполняет различные действия с прямоугольником
    /// </summary>
    public class RectangleHelp
    {
        /// <summary>
        /// получает длину прямоугольника
        /// </summary>
        public float Height { get; set; }

        /// <summary>
        /// получает ширину прямоугольника
        /// </summary>
        public float Width { get; set; }

        /// <summary>
        /// Данный метод проверяет заданную размерность сторон прямоугольника на положительныее значения
        /// </summary>
        /// <param name="height">высота</param>
        /// <param name="width">ширина</param>
        public RectangleHelp(float height, float width)
        {
             Height = height;

             Width = width;
        }

        /// <summary>
        /// Данный метод вычисляет площадь прямоугольника
        /// </summary>
        public void FindArea()
        {
             Console.WriteLine($" Площадь прямоугольника {Height * Width}");
        }

        /// <summary>
        /// Данный метод вычисляет периметр прямоугольника
        /// </summary>
        public void FindPerimeter()
        {
            Console.WriteLine($" Периметр прямоугольника {(Height + Width) * Width}");
        }
    }
}