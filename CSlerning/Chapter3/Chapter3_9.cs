using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSlerning.Chapter3
{
    public class Chapter3_9
    {
        public void reWrite()
        {
            short d = 1;

            for (byte i = 0; i < 10; i++)
                Console.Write(i + d++ + "\t");

            Console.WriteLine();

            d = 1;

            for (byte i = 0; i < 10; i++)
                Console.Write(i + ++d + "\t");
        }
    }
}
