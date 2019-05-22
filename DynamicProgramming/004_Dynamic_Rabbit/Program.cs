using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_Dynamic_Rabbit
{
    class Program
    {

        public static int RabbitMoves (int n, int k)
        {
            int[] moves = new int[n + 1];
            moves[0] = 1;
            for (int i = 1; i <= n; i++)
            {
                int start = Math.Max(0, i - k); // вычисление стартовой позиции
                moves[i] = 0;
                for (int j = start; j < i; j++)
                {
                    moves[i] += moves[j];
                }
            }

            return moves[n];
        }

        static void Main (string[] args)
        {
            Console.WriteLine(RabbitMoves(7 , 2)); // большие значения!
        }
    }
}
