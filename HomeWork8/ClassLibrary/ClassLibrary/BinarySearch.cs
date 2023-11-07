namespace ClassLibrary
{
    public class BinarySearch
    {
        public static int Search<T>(T[] array, T number) where T : IComparable<T>
        {
            var left = 0;

            var right = array.Length - 1;

            while (left <= right)
            {
                var mid = (left + right) / 2;

                if (number.CompareTo(array[mid]) == 0)
                {
                    return mid;
                }
                else if (number.CompareTo(array[mid]) < 0)
                {
                    right = mid - 1;
                }
                else
                {
                     left = mid + 1;
                }
            }
            return -1;
        }
    }
}