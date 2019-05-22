using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007_Queue_Dequeue_Peek
{
    class Program
    {
        static void Main (string[] args)
        {
            SimpleQueue<String> queue = new SimpleQueue<string>();

            queue.Enqueue("Hello");
            queue.Enqueue("world");

            Console.WriteLine(queue.Peek());
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());

            Console.ReadKey();
        }
    }
}
