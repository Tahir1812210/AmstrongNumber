﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmstrongNumber
{
    internal class RhombusShapePatternPrinting
    {
        public static void printRhombus(int n)
        {

            for (int i = 1; i <= n; i++) 
            {

                for (int j = 1; j <= n - i; j++) 
                {
                    Console.Write(" "); 
                }


                for (int k = 1; k <= 2 * i - 1; k++) 
                {
                    Console.Write("*"); 
                }

                Console.WriteLine();
            }

            for (int i = n - 1; i >= 1; i--) 
            {
 
                for (int j = 1; j <= n - i; j++) 
                {
                    Console.Write(" "); 
                }

               
                for (int k = 1; k <= 2 * i - 1; k++) 
                {
                    Console.Write("*"); 
                }

                Console.WriteLine(); 
            }
        }
    }
    }
    
