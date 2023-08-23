using System.Diagnostics;

namespace Perfomance
{
    /// <summary>
    /// В основном классе сравнивается объем занимаемой памяти при иницализации массива классов и структур, а также замеряетсся время их сортировки
    /// </summary>
    public class Program
    {
        static void Main(string[] args)
        {
            var initialMemoryUsage = Process.GetCurrentProcess().PrivateMemorySize64;

            Console.WriteLine($"Размер занимаемой памяти для инициализации: {initialMemoryUsage / 1024} кб");

            var rnd = new Random();

            var classes = new C[100000];

            var structs = new S[100000];

            for (int j = 0; j < classes.Length; j++)
            {
                classes[j] = new C { i = rnd.Next(100) };
            }

            var finalMemoryUsage = Process.GetCurrentProcess().PrivateMemorySize64;

            var privateMemorySizeClasses = finalMemoryUsage - initialMemoryUsage;

            Console.WriteLine($"Размер занимаемой памяти для инициализации массива классов : {privateMemorySizeClasses / 1024} кб");

            initialMemoryUsage = finalMemoryUsage;

            for (int j = 0; j < structs.Length; j++)
            {
                structs[j] = new S { i = rnd.Next(100) };
            }

            finalMemoryUsage = Process.GetCurrentProcess().PrivateMemorySize64;

            var privateMemorySizeStruct = finalMemoryUsage - initialMemoryUsage;

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
            var timer = new Stopwatch();

            timer.Start();

            Array.Sort(classes);

            timer.Stop();

            Console.WriteLine($"Время сортировки класса: {timer.Elapsed}");

            //Замер времени сортировки массива структур

            timer.Reset();
     
            timer.Start();

            Array.Sort(structs);

            timer.Stop();

            Console.WriteLine($"Время сортировки структуры: {timer.Elapsed}");
        }

    }
}
