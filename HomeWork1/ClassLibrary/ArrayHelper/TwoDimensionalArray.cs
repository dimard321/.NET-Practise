namespace ArrayHelper
{
    public class TwoDimensionalArray
    {
        public int x { get; set; }
        public int y { get; set; }


        public TwoDimensionalArray(int y, int x)
        {
            this.x = x;

            this.y = y;
        }

        public void SumElementsTwoDimensionalArray()
        {

            float[,] myArray = new float[y, x];

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
                    } while (!isValidInput);

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