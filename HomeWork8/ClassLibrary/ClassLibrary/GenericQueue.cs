using System.Collections;

namespace ClassLibrary
{
    public class GenericQueue<T> : IEnumerable
    {
        private List<T> items = new List<T>();

        public void Enqueue(T item)
        {
            items.Add(item);
        }

        public T Dequeue()
        {
            if (items is null)
                throw new NullReferenceException("The queue is null.");

            if (items.Count == 0)
                throw new InvalidOperationException("The queue is empty.");
            
            T value = items.FirstOrDefault();

            items.Remove(value);

            return value;
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (T item in items)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
