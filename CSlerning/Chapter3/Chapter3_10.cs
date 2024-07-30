using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSlerning.Chapter3
{
    public class Chapter3_10
    {
        public void reWrite()
        {
            short d = 10, f = 12;
            bool var1 = true, var2 = false;

            if (d < f)
                Console.WriteLine("d < f");
            if (d <= f)
                Console.WriteLine("d <= f");
            if (d != f)
                Console.WriteLine("d != f");

            // Следующее условие не выполнится
            if (d > f)
                Console.WriteLine("d > f");

            // Сравниванием переменные var1 и var2
            if (var1 & var2)
                Console.WriteLine("Данный текст не выведется");
            if (!(var1 & var2))
                Console.WriteLine("!(var1 & var2) = true");
            if (var1 | var2)
                Console.WriteLine("var1 | var2 = true");
            if (var1 ^ var2)
                Console.WriteLine("var1 ^ var2 = true");

        }
    }
}
