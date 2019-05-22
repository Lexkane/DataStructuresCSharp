using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_Stack_Pop_Peek
{
    class SimpleStack<T>
    {
        private class Node
        {
            public T data {get; set;}
            public Node next { get; set; }
            public Node (T data, Node next)
            {
                this.data = data;
                this.next = next;
            }
        }

        private Node top;
        private int count;

        public int Count { get { return count; } }
        public SimpleStack ()
        {
            top = null;
            count = 0;
        }

        public void Push (T item)
        {
            top = new Node(item, top);

            count++;
        }

        public T Pop()
        {
            T result = top.data;
            top = top.next;
            count--;
            return result;
        }

        public T Peek()
        {
            return top.data;
        }

    }
}
