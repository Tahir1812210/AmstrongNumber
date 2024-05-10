using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmstrongNumber
{
    internal class GetTheOddPosition
    {
        public static int GetOddPositionDigit(int number)
        {
            string numstr = number.ToString();
            StringBuilder sb = new StringBuilder();

            for(int i = 0; i<numstr.Length; i++)
            {
                if(i % 2 == 0)
                {
                    sb.Append(numstr[i]);
                }
            }
            return int.Parse(sb.ToString());
        }
    }
}
