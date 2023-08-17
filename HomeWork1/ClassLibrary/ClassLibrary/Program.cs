using ArrayHelper;
using RectangleHelper;

namespace ClassLibrary
{
    internal class Program
    {
        /// <summary>
        ///  Данный метод выполняет проерку на ввод  положительного числового значения
        /// </summary>
        /// <param name="prompt">подсказка</param>
        /// <returns>корректное значние</returns>
        static float ReadRectangle(string prompt)
        {
            float value;

            var validInput = false;

            do
            {
                Console.Write(prompt);

                validInput = float.TryParse(Console.ReadLine(), out value);

                if (!validInput || (value <= 0))
                {
                    Console.WriteLine("Некорректное значение. Пожалуйста, введите число и используйте запятую для десятичных чисел");
                }

            } while (!validInput || (value <= 0));

            return value;
        }

        /// <summary>
        /// Данный метод позволяет задать размерность и вызвать методы выполняющие операции с прямоугольником
        /// </summary>
        static void LaunchRectangle()
        {
            Console.WriteLine("Введите длину и ширину прямоугольника");

            var height = ReadRectangle("Дина: ");

            var weight = ReadRectangle("Ширина: ");

            var rect1 = new RectangleHelp(height, weight);

            rect1.FindArea();

            rect1.FindPerimeter();
        }

        /// <summary>
        ///  Данный метод выполняет проерку на ввод целочисленного значения
        /// </summary>
        /// <returns>корректное значение</returns>
        static int Validate()
        {
            var validInput = false;

            int i;

            do
            {
                validInput = int.TryParse(Console.ReadLine(), out i);

                if (!validInput)
                {
                    Console.WriteLine("Введите корректное значение");
                }
            }
            while (!validInput);

            return i;
        }

        /// <summary>
        /// Данный метод позволяет задать размерность и вызвать методы выполняющие операции с двумерным массиво
        /// </summary>
        static void LaunchTwoDimensionalArray()
        {
            Console.WriteLine("Введите размерность двумерного массива");

            int i = Validate();

            int j = Validate();

            var arr1 = new TwoDimensionalArray(i, j);

            arr1.SumElementsTwoDimensionalArray();
        }

        /// <summary>
        /// Данный метод позволяет задать размерность и вызвать методы выполняющие операции с одномерным массивом
        /// </summary>
        static void LaunchOneDimensionalArray()
        {
            Console.WriteLine("Введите количество эл-ов одномерного массива");

            var lenght = Validate();

            var arr1 = new OneDimensionalArray(lenght);

            arr1.OutputOneDimensionalArray();
        }

        /// <summary>
        /// Данный метод выводит на консоль варианты задавания массива
        /// </summary>
        static void LaunchArray()
        {
            Console.WriteLine("Введите номер операции:\n" +
          "1. Одномерный массив\n" +
          "2. Двумерный массив\n" +
          "3. Вернуться назад\n");

            int func = Validate();

            switch (func)
            {
                case 1:
                    LaunchOneDimensionalArray();

                    break;

                case 2:
                    LaunchTwoDimensionalArray();

                    break;

                case 3:
                    Functional();

                    break;

                default:

                    Console.WriteLine("Введенно неверное значение");

                    LaunchArray();

                    break;
            }
        }


        /// <summary>
        /// Данный метод выводит на консоль варианты вызова классов
        /// </summary>
        static void Functional()
        {
            Console.WriteLine("Введите номер операции:\n" +
          "1. RectangleHelper\n" +
          "2. ArrayHelper\n");

            var func = (FunctionalMenu) Validate();

            switch (func)
            {
                case FunctionalMenu.RectangleHelper:
                    LaunchRectangle();

                    break;

                case FunctionalMenu.ArrayHelper:
                    LaunchArray();

                    break;

                default:

                    Console.WriteLine("Введенно неверное значение");

                    Functional();

                    break;
            }
        }

        static void Main(string[] args)
        {
            Functional();
        }


        enum FunctionalMenu
        {
            RectangleHelper = 1,

            ArrayHelper
        }
    }
}