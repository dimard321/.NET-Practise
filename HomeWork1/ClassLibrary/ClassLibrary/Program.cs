using ArrayHelper;
using RectangleHelper;
using System;
using System.ComponentModel;

namespace ClassLibrary
{
    internal class Program
    {
        /// <summary>
        ///  Данный метод выполняет проерку на ввод  положительного числового значения
        /// </summary>
        /// <param name="prompt"></param>
        /// <returns></returns>
        static float ReadRectangle(string prompt)
        {
            float value;

            bool validInput = false;

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

            float height = ReadRectangle("Высота: ");

            float weight = ReadRectangle("Ширина: ");

            var rect1 = new RectangleHelp(height, weight);

            rect1.FindArea();

            rect1.FindPerimetr();
        }

        /// <summary>
        ///  Данный метод выполняет проерку на ввод целочисленного значения
        /// </summary>
        /// <returns></returns>
        static int Review()
        {
            bool validInput = false;

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

            int i = Review();

            int j = Review();

            var arr1 = new TwoDimensionalArray(i, j);

            arr1.SumElementsTwoDimensionalArray();
        }

        /// <summary>
        /// Данный метод позволяет задать размерность и вызвать методы выполняющие операции с одномерным массивом
        /// </summary>
        static void LaunchOneDimensionalArray()
        {
            Console.WriteLine("Введите количество эл-ов одномерного массива");

            int lenght = Review();

            var arr1 = new OneDimensionalArray(lenght);

            arr1.OutputOneDimensionalArray();
  
        }


        static void LaunchArray()
        {
            Console.WriteLine("Введите номер операции:\n" +
          "1. Одномерный массив\n" +
          "2. Двумерный массив\n" +
          "3. Вернуться назад\n");

            int func = Review();


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



        static void Functional()
        {
            Console.WriteLine("Введите номер операции:\n" +
          "1. RectangleHelper\n" +
          "2. ArrayHelper\n");

            int func = Review();

            switch (func)
            {
                case 1:
                    LaunchRectangle();

                    break;

                case 2:
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

    }
}