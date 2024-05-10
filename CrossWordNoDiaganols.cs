using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmstrongNumber
{
    internal class CrossWordNoDiaganols
    {
        public static int CountWord(char[,] array , string word)
        {
            
            int wordLength = word.Length;
            int colLength = array.GetLength(0);
            int rowCount = array.GetLength(1);
            int count = 0;

            for(int i = 0; i < rowCount; i++) 
            {
                for(int j = 0; j < colLength - wordLength; j++)
                {
                    bool found = true;

                    for(int k=0; k<wordLength; k++)
                    {
                        if (array[i, j+k] != word[k]) 
                        {
                            found = false;
                            break;
                        }
                    }
                    if (found)
                    {
                        count++;
                    }
                }     
            }


            for(int j=0; j < colLength; j++)
            {
                for(int i=0; i <= rowCount - wordLength; i++)
                {
                    bool found = true;
                    for (int k=0; k < wordLength; k++) 
                    {
                        if (array[i, j + k] != word[k])
                        {
                            found = false;
                            break;
                        }
                    }
                    if(found)
                    {
                        count++;
                    }
                }
            }

            return count;
        }


    }
}
