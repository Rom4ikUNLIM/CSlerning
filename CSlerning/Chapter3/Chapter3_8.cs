using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSlerning.Chapter3
{
    public  class Chapter3_8
    {
        public void reWrite()
        {
            int i1 = 455, i2 = 84500;
            decimal dec = 7.98845m;

            // Приводим два числа типа int
            // к типу short
            Console.WriteLine((short)i1);
            Console.WriteLine((short)i2);

            // Приводим число типа decimal
            // к типу int
            Console.WriteLine((int)dec);

        }
    }
}
