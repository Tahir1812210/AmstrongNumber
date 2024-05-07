using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmstrongNumber
{
    internal class FibonacciWithRecursion
    {
        public static int Fibonacci(int number)
        {
            if (number == 0) return 0;

            return number + Fibonacci(number - 1);
        }
    }
}
