using LinkedList.Singly;
using Stack.Contract;

namespace Stack
{
    public class LinkedListStack<T> : IStack<T>
    {
        private SinglyLinkedList<T> _innerList;
        public LinkedListStack()
        {
            _innerList = new SinglyLinkedList<T>();
        }

        public int Count => _innerList.Count; 

       
        public T Peek()
        {
            return _innerList.Head is null
                ? default(T)
                : _innerList.Head.Value;
        }

        public T Pop()
        {
            if (_innerList.Head is null)
                throw new Exception("Underflow! Stack is empty!");
            return _innerList.RemoveFirst();
        }

        // 3 5 7 9
        // [9] -> 7-> 5 -> 3
        public void Push(T item)
        {
            _innerList.AddFirst(item);
        }
    }
}
