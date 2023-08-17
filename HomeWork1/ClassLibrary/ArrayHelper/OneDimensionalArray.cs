
namespace ArrayHelper
{
    /// <summary>
    /// Данный класс производит манипуляции с одномерным массивом 
    /// </summary>
    public class OneDimensionalArray
    {
        /// <summary>
        /// принимает длину массива
        /// </summary>
        public int Lenght { get; set; }

        /// <summary>
        /// получает длину массива
        /// </summary>
        /// <param name="lenght">длина массива</param>
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

            for (var x = 0; x < Lenght; x++)
            {
                float value;

                var isValidInput = false;

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
        /// <param name="arr">одномерный массив</param>
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
        /// <param name="arr">одномерный массив</param>
        public void OptionOneDimensionalArray(float[] arr)
        {
            Console.WriteLine("Введите номер операции:\n" +
                "1. ASC\n" +
                "2. DESC\n");

            var func = int.Parse(Console.ReadLine());

            switch (func)
            {
                case (int)OneDimensionalArrayMenu.ASCSort:

                    SortArrayASC(arr);

                    break;

                case 2:
                    SortArrayDESC(arr);

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
        /// <param name="arr">одномерный массив</param>
        public void SortArrayASC(float[] arr)
        {
            for (var i = 0; i < Lenght - 1; i++)
            {
                for (var x = 0; x < Lenght - 1 - i; x++)
                {
                    if (arr[x] > arr[x + 1])
                    {
                        (arr[x + 1], arr[x]) = (arr[x], arr[x + 1]);
                    }
                }
            }

            PrintOneDimensionalArray(arr);
        }

        /// <summary>
        ///  Данный метод выполняет сортировку DESC
        /// </summary>
        /// <param name="arr">одномерный массив</param>
        public void SortArrayDESC(float[] arr)
        {
            for (var i = 0; i < Lenght - 1; i++)
            {
                for (var x = 0; x < Lenght - 1 - i; x++)
                {
                    if (arr[x] < arr[x + 1])
                    {
                        (arr[x + 1], arr[x]) = (arr[x], arr[x + 1]);
                    }
                }
            }

            PrintOneDimensionalArray(arr);
        }
    }
}

