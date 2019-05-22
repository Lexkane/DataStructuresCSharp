using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _009_Dynamic
{
    class Program
    {

        public static int StraightMethod (int n) // прямой метод
        {
            int[] fibo = new int[n];
            fibo[0] = 1; // начальные значения
            fibo[1] = 1; // начальные значения
            for (int i = 2; i < n; i++)
            {
                fibo[i] = fibo[i - 2] + fibo[i - 1]; //пересчёт значений
            }


            return fibo[n - 1];
        }

        public static int ReverseMethod (int n)
        {
            int[] fibo = new int[n];
            fibo[0] = 1;
            for (int i = 0; i < n - 2; i++)
            {
                fibo[i + 1] += fibo[i];
                fibo[i + 2] += fibo[i];
            }

            return fibo[n - 1] + fibo[n - 2];
        }

        public static int getFibo (int n) // lazy dynamic
        {
            
            if (n < 3)
                return 1;
            return getFibo(n - 1) + getFibo(n - 2);
        }
        static void Main (string[] args)
        {

            int fib = getFibo(5);
        }
    }
}
