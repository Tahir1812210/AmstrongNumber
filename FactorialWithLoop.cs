using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmstrongNumber
{
    internal class FactorialWithLoop
    {
        public static int Factorial(int number)
        {
            int fact = number;
            for(int i=1;i<number;i++)
            {
                fact = fact * i;
            }
            return fact;
        }
    }
}
