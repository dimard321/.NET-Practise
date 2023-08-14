using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayHelper
{
    /// <summary>
    /// Данный класс производит манипуляции с одномерным массивом 
    /// </summary>
    public class OneDimensionalArray
    {
        public int Lenght { get; set; }

        public OneDimensionalArray(int lenght)
        {
            Lenght = lenght;
        }

        /// <summary>
        /// Данный метод выполняет проверку на ввод иных символов помимо чисел
        /// </summary>
        public void OutputOneDimensionalArray()
        {
            var myArray = new float[Lenght];

            for (int x = 0; x < Lenght; x++)
            {
                float value;

                bool isValidInput = false;

                do
                {
                    Console.Write($"Введите значение массива в точке {x}: ");

                    isValidInput = float.TryParse(Console.ReadLine(), out value);

                    if (!isValidInput)
                    {
                        Console.WriteLine("Некорректное значение. Введите число.");
                    }
                }
                while (!isValidInput);

                myArray[x] = value;
            }

            PrintOneDimensionalArray(myArray);

            OptionOneDimensionalArray(myArray);
        }
        /// <summary>
        /// Данный метод выводит одномерный массив на консоль
        /// </summary>
        /// <param name="arr"></param>
        public void PrintOneDimensionalArray(float[] arr)
        {
            Console.Write($" Полученный массив:\t");

            for (var x = 0; x < Lenght; x++)
            {
                Console.Write($" {arr[x]}\t");
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Данный метод выводит на консоль варианты выполнения действий с одномерным массивом
        /// </summary>
        /// <param name="arr"></param>
        public void OptionOneDimensionalArray(float[] arr)
        {
            Console.WriteLine("Введите номер операции:\n" +
         "1. ASC\n" +
         "2. DESC\n");

            int func = int.Parse(Console.ReadLine());

            switch (func)
            {
                case 1:

                    ASC(arr);

                    break;

                case 2:
                    DESC(arr);
                    break;

                default:

                    Console.WriteLine("Введенно неверное значение");

                    OptionOneDimensionalArray(arr);

                    break;
            }
        }

        /// <summary>
        /// Данный метод выполняет сортировку ASC
        /// </summary>
        /// <param name="arr"></param>
        public void ASC(float[] arr)
        {
            float temp;

            for (int i = 0; i < Lenght - 1; i++)
            {
                for (int x = 0; x < Lenght - 1 - i; x++)
                {
                    if (arr[x] > arr[x + 1])
                    {
                        temp = arr[x + 1];

                        arr[x + 1] = arr[x];

                        arr[x] = temp;
                    }

                }
            }

            PrintOneDimensionalArray(arr);
        }

        /// <summary>
        ///  Данный метод выполняет сортировку DESC
        /// </summary>
        /// <param name="arr"></param>
        public void DESC(float[] arr)
        {
            float temp;

            for (int i = 0; i < Lenght - 1; i++)
            {
                for (int x = 0; x < Lenght - 1 - i; x++)
                {
                    if (arr[x] < arr[x + 1])
                    {
                        temp = arr[x + 1];

                        arr[x + 1] = arr[x];

                        arr[x] = temp;
                    }

                }
            }
            PrintOneDimensionalArray(arr);
        }
    }
}

