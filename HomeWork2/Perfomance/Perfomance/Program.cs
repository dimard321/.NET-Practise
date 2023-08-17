using System.Diagnostics;

namespace Perfomance
{
    /// <summary>
    /// класс в котором лежит целочисленное число
    /// </summary>
    public class C : IComparable<C>
    {
        public int i;
        public int CompareTo(C other)
        {
            // Сравниваем объекты на основе значения i
            return i.CompareTo(other.i);
        }
    }

    /// <summary>
    /// структура в которой лежит целочисленное число
    /// </summary>
    public struct S : IComparable<S>
    {
        public int i;
        public int CompareTo(S other)
        {
            // Сравниваем объекты на основе значения i
            return i.CompareTo(other.i);
        }
    }

    /// <summary>
    /// В основном классе сравнивается объем занимаемой памяти при иницализации массива классов и структур, а также замеряетсся время их сортировки
    /// </summary>
    public class Program
    {
        static void Main(string[] args)
        {
            Process process = Process.GetCurrentProcess();

            long privateMemorySizeInitially = process.PrivateMemorySize64;

            Console.WriteLine($"Размер занимаемой памяти для инициализации: {privateMemorySizeInitially / 1024} кб");

            var rnd = new Random();

            var classes = new C[100000];

            var structs = new S[100000];

            for (int j = 0; j < classes.Length; j++)
            {
                classes[j] = new C { i = rnd.Next(100) };
            }

            Process process1 = Process.GetCurrentProcess();

            long privateMemorySizeClasses = process1.PrivateMemorySize64 - process.PrivateMemorySize64;

            Console.WriteLine($"Размер занимаемой памяти для инициализации массива классов : {privateMemorySizeClasses / 1024} кб");

            for (int j = 0; j < structs.Length; j++)
            {
                structs[j] = new S { i = rnd.Next(100) };
            }

            Process process2 = Process.GetCurrentProcess();

            long privateMemorySizeStruct = process2.PrivateMemorySize64 - process1.PrivateMemorySize64;

            Console.WriteLine($"Размер занимаемой памяти для инициализации массива структур: {privateMemorySizeStruct / 1024} кб");

            if (privateMemorySizeClasses > privateMemorySizeStruct)
            {
                Console.WriteLine($"Разница в объме занимаемой памяти для инициализации массива структур и классов: {(privateMemorySizeClasses - privateMemorySizeStruct) / 1024} кб ");

                Console.WriteLine($"Таким образом эффективнее использовать структуры");
            }
            else
            {
                Console.WriteLine($"Разница в объме занимаемой памяти для инициализации массива структур и классов: {(privateMemorySizeStruct - privateMemorySizeClasses) / 1024} кб");

                Console.WriteLine($"Таким образом эффективнее использовать классы");
            }

            //Замер времени сортировки массива классов
            var timeClass = new Stopwatch();

            timeClass.Start();

            Array.Sort(classes);

            timeClass.Stop();

            Console.WriteLine($"Время сортировки класса: {timeClass.Elapsed}");

            //Замер времени сортировки массива структур
            var timeStruct = new Stopwatch();

            timeStruct.Start();

            Array.Sort(structs);

            timeStruct.Stop();

            Console.WriteLine($"Время сортировки структуры: {timeClass.Elapsed}");
        }

    }
}
