﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010_Practice_Tasks
{
    class Program
    {
        public static void HanoiTowers(int quantity, int from, int to, int buf_peg)	{
        if (quantity != 0)
        {
            HanoiTowers(quantity-1, from, buf_peg, to);

            Console.WriteLine(from + " -> " + to);
 
            HanoiTowers(quantity-1, buf_peg, to, from);
        }
    }
        static void Main (string[] args)
        {
            HanoiTowers(3, 1, 3, 2);
        }
    }
}
