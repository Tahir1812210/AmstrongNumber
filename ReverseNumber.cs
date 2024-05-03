using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmstrongNumber
{
    internal class ReverseNumber
    {
        public static int CalcuateReverseNumber(int number)
        {
            int reverse = 0;
    
            while (number != 0)
            {
                int lastNumber = number % 10;
                reverse = (reverse * 10) + lastNumber;
                number /= 10;
            }
            return reverse;
        }

        public static void GenerateNumber(int start, int end)
        {
            Console.WriteLine($"Reversed number between {start} and {end}");
            for(int i = start; i<=end; i++)
            {
                int reversed = CalcuateReverseNumber(i);
                Console.WriteLine($"Original: {i}, Reversed: {reversed}");
            }
        }

    }
}
