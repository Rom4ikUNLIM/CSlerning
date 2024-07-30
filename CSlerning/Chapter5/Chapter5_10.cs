using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSlerning.Chapter5
{
    public class Chapter5_10
    {
        static int mySum(int a, int b = 5, int c = 10)
        {
            return a + b + c;
        }

        public void reWrite()
        {
            // Использование именованных аргументов
            // при вызове метода
            int sum1 = mySum(a: 3, b: 10);
            Console.WriteLine("Sum1 = " + sum1);
        }
    }
}
