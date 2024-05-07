using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmstrongNumber
{
    internal class FibonacciSequenceWithLoop
    {
        public static int FebonacciWithLoop(int number)
        {
            int fib = 0;
            for(int i = 1;  i <= number; i++) 
            {
                fib = fib + i;
            }
            return fib;
        }
    }
}
