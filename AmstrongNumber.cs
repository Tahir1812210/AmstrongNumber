using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmstrongNumber
{
    public class AmstrongNumber
    {
        public static int CountNumber(int number)
        {
            return number.ToString().Length;    
        }

        public static bool isAmstrong(int number)
        {
            int digits = CountNumber(number);

            int originalNumber = number;

            int sum = 0;

            while (number > 0) 
            {
                int digit = number % 10;

               ;

                sum += (int)Math.Pow(digit, digits);

                number /= 10;

            }
            return sum == originalNumber;
        }


        public static void GenerateAmstrong(int start , int end)
        {
            Console.WriteLine($"Amstrong Number between {start} and {end}");

            for(int i = start; i < end; i++) 
            {
                if(isAmstrong(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

    }
}
