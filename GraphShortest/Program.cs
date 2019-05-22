using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008_Graphs_Part_3
{
    class Program
    {
        static void Main (string[] args)
        {
            double[,] g = new double[,]{
                {0, 5, 0, 6, 0, 50},
                {5, 0, 7, 0, 0, 0},
                {0, 7, 0, 4, 0, 10},
                {6, 0, 4, 0, 10, 0},
                {0, 0, 0, 10, 0, 8},
                {50, 0, 10, 0, 8, 0}
            };

            Graph graph = new Graph(g);

            double[,] dist = graph.GetAllShortestPath();

            Console.WriteLine(dist[0,5]);
        }
    }
}
