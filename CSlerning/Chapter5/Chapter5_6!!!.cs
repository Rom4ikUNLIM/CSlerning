using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//КОД НЕ РАБОТАЕТ. ПРИЧИНА НЕ ИЗВЕСТНА!!!!!!!!!!!!!!!!


namespace CSlerning.Chapter5
{
    public class Chapter5_6
    {
        int k;
        public Chapter5_6(int i)
        {
            k = i;
        }

        //деструктор
        ~Chapter5_6()
        {
            Console.WriteLine("Объект {0} уничтожен", k);
        }
        //метод создающий и тут же уничтожающий объект 
        public void objectGeneration(int i)
        {
            Chapter5_6 ob = new Chapter5_6(i);
        }
    }

    public class Program
    {
        public void reWrite()
        {
            int i = 1;
            Chapter5_6 obj = new Chapter5_6(0);

            for (; i < 120000; i++)
            {
                obj.objectGeneration(i);
            }

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nКонец");
        }
    }
}