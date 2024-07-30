using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSlerning.Chapter4
{
    public  class Chapter4_6
    {
        //данный метод возвращает кортеж с 4ми различными значениями
        static Tuple<int, float, string, char> Corteg(int a, string name)
        {
            int sqr = a * a;
            float sqrt = (float)(Math.Sqrt(a));
            string s = "Привет, " + name;
            char ch = (char)(name[0]);

            return Tuple.Create<int, float, string, char>(sqr, sqrt, s, ch);
        }
        public void reWrite()
        {
            var myTuple = Corteg(25, "Alexandr");
            Console.WriteLine("{0}\n25 в квадрате: {1}\nКвадратный корень из 25: " + "{2}\nПервый символ в имени: {3}\n", myTuple.Item3, myTuple.Item1, myTuple.Item2, myTuple.Item4);
        }
    }
}
