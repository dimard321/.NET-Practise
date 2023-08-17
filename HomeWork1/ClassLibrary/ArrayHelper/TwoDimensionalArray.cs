using System.Diagnostics.Metrics;

namespace ArrayHelper
{
    /// <summary>
    ///  Данный класс выполняет различные действия с двумерным массивом
    /// </summary>
    public class TwoDimensionalArray
    {
        /// <summary>
        /// получает размер двумерного массива по координате Х
        /// </summary>
        public int X { get; set; }

        /// <summary>
        /// получает размер двумерного массива по координате Y
        /// </summary>
        public int Y { get; set; }

        /// <summary>
        /// Инициализирует размерность массива
        /// </summary>
        /// <param name="y">координата у</param>
        /// <param name="x">координата х</param>
        public TwoDimensionalArray(int y, int x)
        {
            X = x;

            Y = y;
        }

        /// <summary>
        /// Данный метод суммирует все положительные элементы двумерного массива
        /// </summary>
        public void SumElementsTwoDimensionalArray()
        {
            var myArray = new float[Y, X];

            float counter = 0;

            for (var i = 0; i < myArray.GetLength(0); i++)
            {
                for (var j = 0; j < myArray.GetLength(1); j++)
                {
                    float value;

                    var isValidInput = false;

                    do
                    {
                        Console.Write($"Введите значение массива в точке {i},{j}: ");

                        isValidInput = float.TryParse(Console.ReadLine(), out value);

                        if (!isValidInput)
                        {
                            Console.WriteLine("Некорректное значение. Введите число.");
                        }
                    }
                    while (!isValidInput);

                    myArray[i, j] = value;

                    if (myArray[i, j] >= 0)
                    {
                        counter += myArray[i, j];
                    }
                }
            }

            Console.WriteLine($"Сумма положительных элементов массива: {counter}");

            PrintElementsTwoDimensionalArray(myArray);
        }

        /// <summary>
        /// Выводит двумерный массив на консоль
        /// </summary>
        /// <param name="myArray">передается двумерный массив</param>
        public void PrintElementsTwoDimensionalArray(float[,] myArray)
        {
            Console.WriteLine($"\tПолученный массив:");

            for (var i = 0; i < myArray.GetLength(0); i++)
            {
                for (var j = 0; j < myArray.GetLength(1); j++)
                {
                    Console.Write($"{myArray[i, j]}\t");
                }

                Console.WriteLine();
            }
        }
    }
}