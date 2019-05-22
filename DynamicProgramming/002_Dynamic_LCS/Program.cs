using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_Dynamic_LCS
{
    class Program // Longest Common Subsequence
    {

        public static int LCS (string s1, string s2)
        {
            int n = s1.Length;
            int m = s2.Length;

            int[,] lcs = new int[n + 1, m + 1];

            for (int i = 1; i < n; i++)
            {
                for (int j = 1; j < m; j++)
                {
                    if (s1[i].Equals(s2[j]))
                        lcs[i, j] = lcs[i - 1, j - 1] + 1;
                    else
                        lcs[i, j] = Math.Max(lcs[i - 1, j], lcs[i, j - 1]);
                }
            }

            return lcs[n, m];
        }
        static void Main (string[] args)
        {
        }
    }
}
