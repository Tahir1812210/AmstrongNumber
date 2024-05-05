using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmstrongNumber
{
    internal class RecursionName
    {
        public static void PrintName(string name , int count)
        {
            if (count <= 0) return;

            Console.WriteLine(name);

            PrintName(name, count - 1);
        }
    }
}
