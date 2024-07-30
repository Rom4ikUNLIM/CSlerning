using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSlerning.Chapter5
{
    public class Chapter5_9
    {
        //метод изменяющий свой аргумент
        static void myCh(ref char c)
        {
            c = 'A';
        }

        static void Swap(ref char a, ref char b)
        {
            char c;
            c = a;
            a = b;  
            b = c;
        }

        public void reWrite()
        {
            char ch = 'B', s1 = 'D', s2 = 'F';
            Console.WriteLine("Переменная ch до вызова метода myCh: {0}",ch);
            myCh(ref ch);
            Console.WriteLine("Переменная ch после вызова метода myCh: {0}", ch);

            Console.WriteLine("\nПеременная s1 = {0}, переменная s2 = {1}", s1, s2);
            Swap(ref s1, ref s2);
            Console.WriteLine("Теперь s1 = {0}, s2 = {1}", s1, s2);
        }
    }
}
