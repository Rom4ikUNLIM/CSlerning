using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSlerning.Chapter5
{ 
    public class Chapter5_11
    {
        static int factorial(int i)
        {
            int result;

            if (i == 1)
                result = 1;
            result = factorial(i - 1) * i;
            return result;
        }

        public void reWrite()
        {
        label1:
            Console.WriteLine("Введите число: ");
            try
            {
                int i = int.Parse(Console.ReadLine());
                Console.WriteLine("{0}! = {1}", i, factorial);

            }
            catch(FormatException)
            {
                Console.WriteLine("Некорректное число");
                goto label1;
            }
        }
    }


}
