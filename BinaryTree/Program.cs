using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008_BinaryTree_Traversals
{
    class Program
    {
        static void Main (string[] args)
        {
            BinaryTree<int> instance = new BinaryTree<int>();

            instance.Add(8);    //                        8
            instance.Add(5);    //                      /   \
            instance.Add(12);   //                     5    12 
            instance.Add(3);    //                    / \   / \  
            instance.Add(7);    //                   3   7 10 15
            instance.Add(10);   //
            instance.Add(15);   //


            //instance.InOrderTraversal(); // 3 5 7 8 12 10 15
            //instance.PostOrderTraversal(); // 3 7 5 8 10 15 12 8
            //instance.PreOrderTraversal(); // 8 5 3 7 12 10 15 

            Console.ReadKey();
        }
    }
}
