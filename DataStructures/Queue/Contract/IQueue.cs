using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue.Contract
{
    public interface IQueue<T>
    {
        public int Count { get; }
        public void EnQueue(T item);
        public T DeQueue();

        public T Peek();
    }
}
