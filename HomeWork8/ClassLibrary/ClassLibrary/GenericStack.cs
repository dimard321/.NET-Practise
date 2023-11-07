using System.Collections;
using System.Collections.Generic;
using System.Security;

namespace ClassLibrary
{
    public class GenericStack<T> : IEnumerable<T>
    {
        private LinkedList<T> items = new();
        //двусвязный список необходим для того чтобы итерироваться в обратном порядке, чтобы это выглядело как какноничный стек.
        //двусвязный список имеет указатель как на следующий элемент, так и на предыдущий, что отражено в методе GetEnumerator().

        public void Push(T item)
        {
            items.AddLast(item);
        }

        public T Pop()
        {
            if (items.Count == 0)
                throw new InvalidOperationException("The stack is empty.");

            T value = items.Last.Value;

            items.RemoveLast();

            return value;
        }

        public IEnumerator<T> GetEnumerator()
        {
            var lastNode = items.Last;

            for (var currentNode = lastNode; currentNode != null; currentNode = currentNode.Previous)
            {
                yield return currentNode.Value;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
