using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSlerning.Chapter3
{
    public class Chapter3_13
    {
        public void reWrite()
        {
            int result;

            //анализируем функцию модуля числа 
            for (int i = 5; i >= -5; i--)
            {
                result = i >= 0 ? i : -i;
                Console.WriteLine("{0}\t",result);
            }

            Console.WriteLine("\n\n");

            //выбор чётных чисел
            for (int i = 0; i < 10; i++)
            {
                if (i % 2 == 0 ? true : false)
                    Console.WriteLine("{0}\t",i);
            }
        }
    }
}
