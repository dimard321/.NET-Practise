using System.Runtime.InteropServices;

namespace RectangleHelper
{
    public class RectangleHelp
    {
        public float height { get; set; }
        public float width { get; set; }

        public RectangleHelp(float height, float width)
        {
            if (((width > 0) && (height > 0)))
            {
                this.height = height;

                this.width = width;
            }
            else
            {
                Console.WriteLine("Некорректное значение. Данного прямоугольника не существует");
            }
        }

        public void FindArea()
        {
            float result = height * width;

             Console.WriteLine($" Площадь прямоугольника {result}");
        }

        public void FindPerimetr()
        {
            float result = (height + width) * width;

            Console.WriteLine($" Периметр прямоугольника {result}");
        }
        static float ReadRectangle(string prompt)
        {
            float value;

            bool validInput = false;

            do
            {
                Console.Write(prompt);

                validInput = float.TryParse(Console.ReadLine(), out value);

                if (!validInput)
                {
                    Console.WriteLine("Некорректное значение. Пожалуйста, введите число и используйте запятую для десятичных чисел");
                }

            } while (!validInput);

            return value;
        }


    }
}