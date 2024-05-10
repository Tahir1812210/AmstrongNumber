using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmstrongNumber
{
    internal class BestRoute
    {
        public static int CalculateCost(int cost , int day)
        {
            return cost * day;
        }

        public static void FindBestRoute()
        {
            int cost1 = 2;
            int day1 = 11;

            int cost2 = 4;
            int day2 = 6;

            int package1 = cost1 * day1;
            int package2 = cost2 * day2;

            if(package1 < package2) 
            {
                Console.WriteLine("The best route is the 11 day option because it comes with the lowest" +
                    $"price which is ${package1} ");
            }
            else
            {
                Console.WriteLine("The best route is the 6 day option because it comes with the lowest" +
                   $"price which is ${package2} ");
            }
        }

    }
}
