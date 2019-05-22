using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008_Set
{
    class Program
    {
        static void Main (string[] args)
        {
            SimpleSet<int> instance = new SimpleSet<int>();

            instance.Add(1);
            instance.Add(2);
            instance.Add(3);
            instance.Add(4);
            instance.Add(5);
            //instance.Add(5); // снять комментарий для получения ошибки о уже содержащемся элементе

            int[] array = { 10, 20, 30, 40, 50 };
            instance.AddRange(array);

            foreach (var item in instance)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
