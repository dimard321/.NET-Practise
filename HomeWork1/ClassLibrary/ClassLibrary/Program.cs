using ArrayHelper;
using RectangleHelper;
using System;
using System.ComponentModel;

namespace ClassLibrary
{
    internal class Program
    {
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

        static void LaunchRectangle()
        {
            Console.WriteLine("Введите длину и ширину прямоугольника");

            float height = ReadRectangle("Высота: ");
            float weight = ReadRectangle("Ширина: ");

            var rect1 = new RectangleHelp(height, weight);

            rect1.FindArea();

            rect1.FindPerimetr();
        }

        static int ReadArray()
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
        static void LaunchTwoDimensionalArray()
        {
            Console.WriteLine("Введите размерность двумерного массива");

            int i = ReadArray();

            int j = ReadArray();

            var arr1 = new ArrayHelp(i, j);

            arr1.SumElementsTwoDimensionalArray();
        }

        static void LaunchOneDimensionalArray()
        {
            Console.WriteLine("Введите количество эл-ов одномерного массива");

            int lenght = ReadArray();

            var arr1 = new ArrayHelp(lenght);

            arr1.OutputOneDimensionalArray();
  
        }


        static void LaunchArray()
        {
            Console.WriteLine("Введите номер операции:\n" +
          "1. Одномерный массив\n" +
          "2. Двумерный массив\n");

            int func = int.Parse(Console.ReadLine());
            switch (func)
            {
                case 1:
                    LaunchOneDimensionalArray();

                    break;

                case 2:
                    LaunchTwoDimensionalArray();

                    break;

                default:

                    Console.WriteLine("Введенно неверное значение");

                    break;
            }
        }



        static void Functional()
        {
            Console.WriteLine("Введите номер операции:\n" +
          "1. RectangleHelper\n" +
          "2. ArrayHelper\n");

            int func = int.Parse(Console.ReadLine());

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