namespace ArrayHelper
{
    public class ArrayHelp
    {
        public int x { get; set; }
        public int y { get; set; }
        public int lenght { get; set; }

        public ArrayHelp(int y, int x)
        {
            this.x = x;

            this.y = y;
        }
        public ArrayHelp(int lenght)
        {
            this.lenght = lenght;
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
       
        public void OutputOneDimensionalArray()
        {

            float[] myArray = new float[lenght];

            for (int x = 0; x < lenght; x++)
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
                } while (!isValidInput);

                 myArray[x] = value;
            }

            PrintOneDimensionalArray(myArray);

            OptionOneDimensionalArray(myArray);
        }
        public void PrintOneDimensionalArray(float[] arr)
        {
            Console.Write($" Полученный массив:\t");

            for (int x = 0; x < lenght; x++)
            {
                Console.Write($" {arr[x]}\t");
            }
            Console.WriteLine();
        }
          
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

        public void ASC(float[] arr)
        {
            float temp;

            for (int i = 0; i < lenght-1; i++)
            {
                for (int x = 0; x < lenght - 1 - i; x++)
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
        public void DESC(float[] arr)
        {
            float temp;

            for (int i = 0; i < lenght - 1; i++)
            {
                for (int x = lenght-1; x > 0; x--)
                {
                    if (arr[x] < arr[x - 1])
                    {
                        temp = arr[x - 1];

                        arr[x - 1] = arr[x];

                        arr[x] = temp;
                    }

                }
            }

            PrintOneDimensionalArray(arr);
        }
    }
}