using System.Diagnostics.CodeAnalysis;

namespace ClassLibrary
{
    public static class Fibonacci
    {
        public static IEnumerable<int> GetFibonacci(int sequenceLength)
        {
            int prev = -1;

            int next = 1;

            for (int i = 0; i < sequenceLength; i++)
            {
               int sum = next + prev;

                prev = next;

                next = sum;

                yield return sum;
            }
        }
    }
}
