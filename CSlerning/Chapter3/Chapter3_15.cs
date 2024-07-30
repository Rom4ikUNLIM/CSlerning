using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSlerning.Chapter3
{
    public class Chapter3_15
    {
        public void reWrite()
        {
            byte l = 2, i = 0;
            int result = 1;

            while (i < 10)
            {
                i++;
                result *= l; // result = result * l
                Console.WriteLine("{0} в степени {1} равно {2}", l, i, result);
            }
        }
    }
}
