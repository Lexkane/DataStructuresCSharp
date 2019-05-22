using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006_Graphs
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

            g.BFS(1);

            Console.ReadKey();
        }
    }
}
