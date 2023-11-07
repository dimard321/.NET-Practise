using ClassLibrary;

namespace MyConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Пример использования BinarySearch
            int[] numbers = { 1, 3, 5, 7, 9, 12, 16, 19 };

            int target = 5;

            int index = BinarySearch.Search(numbers, target);

            Console.WriteLine($"Index of {target} is {index}\n");

            // Пример использования Fibonacci
            Console.WriteLine("Fibonacci Sequence:");

            foreach (int fib in Fibonacci.GetFibonacci(10))
            {
                Console.Write(fib + " ");
            }

            Console.WriteLine("\n");

            // Пример использования GenericStackQueue
            var stack = new GenericStack<string>();

            stack.Push("A");

            stack.Push("B");

            stack.Push("C");

            Console.WriteLine("Стэк: ");

            foreach(var item in stack)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine($" Удалён элемент из стека: { stack.Pop()}");

            Console.WriteLine(Environment.NewLine);

            var queue = new GenericQueue<string>();

            queue.Enqueue("A");

            queue.Enqueue("B");

            queue.Enqueue("C");

            Console.WriteLine("Очередь: ");

            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine($" Удалён элемент из стека: {queue.Dequeue()}");

            //stackQueue.Enqueue("C");

            //Console.WriteLine("Stack/Queue Contents:");

            //foreach (var item in stackQueue)
            //{
            //    Console.WriteLine(item);
            //}
        }
    }
}