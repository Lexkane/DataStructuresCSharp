using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_Graph_DFS
{
    class Program
    {
        static void Main (string[] args)
        {
            double[,] arr = new double[,] 
            { 
                {0, 1, 1, 0},
                {0, 0, 1, 1},
                {1, 0, 0, 1},
                {0, 1, 0, 0}
            };

            Graph g = new Graph(arr);

            g.DFS(1);

            Console.ReadKey();
        }
    }
}
