using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_Stack_Pop_Peek
{
    class Program
    {
        static void Main (string[] args)
        {
            SimpleStack<int> stack = new SimpleStack<int>();

            stack.Push(1);
            stack.Push(2);
            stack.Push(10);

            int res = stack.Pop();
            res = stack.Pop();
            res = stack.Peek();
            res = stack.Peek();

        }
    }
}
