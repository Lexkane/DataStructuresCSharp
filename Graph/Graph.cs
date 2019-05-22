using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006_Graphs
{
    class Graph
    {
        private double[,] list;
        private int n;
        public Graph (int n)
        {
            list = new double[n,n];
            this.n = n;
        }

        public Graph (double[,] arr)
        {
            list = arr;
            this.n = arr.GetLength(0);
        }
        public void Add (int from, int to, double cost)
        {
            list[from, to] = cost;
        }

        public void BFS (int from)
        {
            bool[] visited = new bool[n];
            Queue<int> turn = new Queue<int>();
            turn.Enqueue(from);
            visited[from] = true;
            while (turn.Count != 0)
            {
                int index = turn.Dequeue();
                Console.WriteLine(index);
                
                for (int i = 0; i < n; i++)
                {
                    if (list[index, i] != 0 && !visited[i])
                    {
                        visited[i] = true;
                        turn.Enqueue(i);
                    }
                }
            }
        }
    }
}
