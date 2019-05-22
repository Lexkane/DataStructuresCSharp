using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_HashTable_Get_Clear_LoadFactor
{
    class Program
    {
        static void Main (string[] args)
        {
            HashTable<String, String> table = new HashTable<string, string>(2);

            table.Add("Name", "Ivan");
            table.Add("Surname", "Petrov");
            table.Add("Phone Number", "1234567890");

            var val = table.GetValue("Surname");
            val = table.GetValue("Bad");

            table.Clear();

            table.Add("Name", "Ivan");
            table.Add("Surname", "Petrov");
            table.Add("Phone Number", "1234567890");
        }
    }
}
