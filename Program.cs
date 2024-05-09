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
            //int number = 134;
            //int value = GetTheOddPosition.GetOddPositionDigit(number);
            //Console.WriteLine(value);
            //Console.ReadLine();

            char[,] crossword =
            {
            { 'e', 'l', 'e', 'p', 'h', 'a', 'n', 't' }, 
            { 't', 'a', 'x', 'y', 'o', 'n', 'p', 'e' }, 
            { 'l', 'e', 'a', 'o', 't', 'a', 'l', 'o' }, 
            { 'p', 'h', 'l', 'l', 's', 'a', 'x', 'g' }, 
            { 'a', 'y', 'x', 'b', 'l', 'o', 'b', 'o' }  
            };


            string animalName = "elephant";

            int count = CrossWordNoDiaganols.CountWord(crossword, animalName);
            Console.WriteLine(count);
            Console.ReadLine();
            } } }
