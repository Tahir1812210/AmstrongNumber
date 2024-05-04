using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AmstrongNumber
{
    internal class PallindromeNumber
    {
        public static int calculateReverse(int number, out bool isOverFlow)
        {
            isOverFlow = false;
            int reverse = 0;
            int preRev = 0;
            while(number > 0)
            {
                int remainder = number % 10;


                reverse = (reverse * 10) + remainder;

                if (reverse < preRev)
                {
                    isOverFlow = true;
                    return 0;
                }

                    number /= 10;
            }

            return reverse;
        }


        public static bool isPalindrome(int number)
        {
            if (number < 0) return false;
            int originalNumber = number;
            bool isOverFlow;
            int reverseNumber = calculateReverse(number, out isOverFlow);

            if (isOverFlow) return false;
            return number == reverseNumber;
        }


        public static void generatePalindrome(int start , int end)
        {
            if (start < 0 || end < 0)
            {
                Console.WriteLine("Start and End must not be negative");
                return;
            }

            Console.WriteLine($"numbers from {start} to {end} are: ");

            for(int i =start; i<=end; i++)
            {
                if(isPalindrome(i))
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
