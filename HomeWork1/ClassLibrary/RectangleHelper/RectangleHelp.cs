using System.Runtime.InteropServices;

namespace RectangleHelper
{
    /// <summary>
    /// Данный класс выполняет различные действия с прямоугольником
    /// </summary>
    public class RectangleHelp
    {
        public float Height { get; set; }
        public float Width { get; set; }

        /// <summary>
        /// Данный метод проверяет заданную размерность сторон прямоугольника на положительныее значения
        /// </summary>
        /// <param name="height"></param>
        /// <param name="width"></param>
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
        public void FindPerimetr()
        {
            Console.WriteLine($" Периметр прямоугольника {(Height + Width) * Width}");
        }
    }
}