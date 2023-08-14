namespace ArrayHelper
{
    public class TwoDimensionalArray
    {
        public int X { get; set; }
        public int Y { get; set; }


        public TwoDimensionalArray(int y, int x)
        {
            X = x;

            this.Y = y;
        }

        /// <summary>
        /// Данный метод суммирует все положительные элементы двумерного массива
        /// </summary>
        public void SumElementsTwoDimensionalArray()
        {

            float[,] myArray = new float[Y, X];

            float counter = 0;

            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {

                    float value;

                    bool isValidInput = false;

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

            Console.WriteLine($"\tПолученный массив:");

            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    Console.Write($"{myArray[i, j]}\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine($"Сумма положительных элементов массива: {counter}");
        }

    }
}