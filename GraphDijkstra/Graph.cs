using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_Graph_Dijkstra
{
    class Graph
    {
        private double[,] list;
        private int n;
        public Graph (int n)
        {
            list = new double[n, n];
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

        public IList<int> BFS (int from)
        {
            bool[] visited = new bool[n];
            Queue<int> turn = new Queue<int>();
            IList<int> result = new List<int>();

            turn.Enqueue(from);
            visited[from] = true;

            while (turn.Count != 0)
            {
                int index = turn.Dequeue();

                result.Add(index);

                for (int i = 0; i < n; i++)
                {
                    if (list[index, i] != 0 && !visited[i])
                    {
                        visited[i] = true;
                        turn.Enqueue(i);
                    }
                }
            }

            return result;
        }

        public IList<int> DFS (int from)
        {
            bool[] visited = new bool[n];
            Stack<int> stack = new Stack<int>();
            IList<int> result = new List<int>();

            stack.Push(from);
            visited[from] = true;

            while (stack.Count != 0)
            {
                int index = stack.Pop();

                result.Add(index);

                for (int i = 0; i < n; i++)
                {
                    if (!visited[i] && list[index, i] != 0)
                    {
                        stack.Push(i);
                        visited[i] = true;
                    }
                }
            }

            return result;

        }

        public int DegreeOfVertex (int vertex)
        {
            int degree = 0;
            for (int i = 0; i < n; i++)
            {
                if (list[vertex,i] != 0)
                    degree++;
            }
            return degree;
        }
        
    }
}
