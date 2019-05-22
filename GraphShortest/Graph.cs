using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008_Graphs_Part_3
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
                if (list[vertex, i] != 0)
                    degree++;
            }
            return degree;
        }

        public IList<double> GetShortestPath (int start)
        {
            List<double> distance = new List<double>();
            bool[] visited = new bool[n];
            for (int i = 0; i < n; i++)
            {
                distance.Add(double.MaxValue);
                visited[i] = false;
            }

            distance[start] = 0;
            int index = -1;
            for (int i = 0; i < n; i++)
            {
                double min = double.MaxValue;
                for (int j = 0; j < n; j++)
                {
                    if (!visited[j] && distance[j] <= min)
                    {
                        min = distance[j];
                        index = j;
                    }
                }

                visited[index] = true;
                for (int j = 0; j < n; j++)
                {
                    if (!visited[j] && list[index, j] > -1
                        && distance[index] != double.MaxValue
                        && distance[index] + list[index, j] < distance[j])
                        distance[j] = distance[index] + list[index, j];
                }
            }

            return distance;

        }

        public double[,] GetAllShortestPath ()
        {
            double[,] distances = new double[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    distances[i, j] = list[i, j];
                }
            }

            for (int k = 0; k < n; k++)
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {


                        if (distances[i, k] != 0 && distances[k, j] != 0 && i != j)
                        {
                            //distances[i, j] = Math.Min(distances[i, j], distances[i, k] + distances[k, j]);
                            if (distances[i, k] + distances[k, j] < distances[i, j] || distances[i, j] == 0)
                                distances[i, j] = distances[i, k] + distances[k, j];
                        }
                    }
                }
            }

            return distances;
        }

    }
}
