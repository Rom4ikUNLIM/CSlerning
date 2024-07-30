using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSlerning.Chapter3
{
    public class Chapter3_16
    {
        public void reWrite()
        {
            try
            {
                //вычисляем факториал числа

                int i, result = 1, num = 1;

                Console.WriteLine("Введите число:");
                i = int.Parse(Console.ReadLine());

                Console.WriteLine("\n\nФакториал {0} = ", i);
                do
                {
                    result *= num; // result = result * num
                    num++;
                } while (num <= i);

                Console.WriteLine(result);
            }
            catch(FormatException ex)
            {
                Console.WriteLine("Вы ввели не число {0}", ex.Message);
            }
        }
    }
}
