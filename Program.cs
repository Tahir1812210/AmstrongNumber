using System;
using AmstrongNumber; // Import the namespace where your class is defined

namespace AmstrongNumber // Define your main application namespace
{
    class Program
    {
        static void Main(string[] args)
        {
            //AmstrongNumber.GenerateAmstrong(1, 1000);

            //int testnumber = 153;
            //AmstrongNumber.isAmstrong(testnumber);

            //Console.WriteLine($"{testnumber} is an amstrong number");

            //ReverseNumber.GenerateNumber(10, 20);

            //PallindromeNumber.generatePalindrome(100, 200);
            //RecursionName.PrintName("Tahir", 10);
            //int value = FactorialWithRecursion.Factorial(10);
            //Console.WriteLine(value);

            //int value = FactorialWithLoop.Factorial(10);
            //Console.WriteLine(value);

            //int value = FibonacciSequenceWithLoop.FebonacciWithLoop(4);
            //Console.WriteLine(value);

            //int value = FibonacciWithRecursion.Fibonacci(4);
            //Console.WriteLine(value);
            int number = 134;
            int value = GetTheOddPosition.GetOddPositionDigit(number);
            Console.WriteLine(value);
            Console.ReadLine();
        }
    }
}
