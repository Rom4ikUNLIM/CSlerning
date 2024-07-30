using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSlerning.Chapter3
{
    public class chapter3_17
    {
        public void reWrite()
        {
            int result = Sum(230);
            Console.WriteLine("Сумма четных чисел от 1 до 230 равна: " + result);

            Console.ReadLine();
        }

        // Метод, возращающий сумму всех четных чисел
        // от 1 до s
        public int Sum(int s)
        {
            int mySum = 0;
            for (int i = 1; i <= s; i++)
                if (i % 2 == 0)
                    mySum += i;
            return mySum;
        }
    }
}
