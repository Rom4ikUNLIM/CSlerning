using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSlerning.Chapter5
{
    public class Chapter5_7
    {
        public char ch;

        public void Method1(char ch)
        {
            ch = ch;
        }
        public void Method2(char ch)
        {
            this.ch = ch;
        }

        public void reWrite()
        {
            char myCH = 'A';
            Console.WriteLine("Исходный символ {0}", myCH);

            Chapter5_7 obj = new Chapter5_7();

            obj.Method1(myCH);
            Console.WriteLine("Использование метода без ключевого слова this: {0}", obj.ch);
            obj.Method2(myCH);
            Console.WriteLine("Использование метода c ключевым словом this: {0}", obj.ch);
            Console.ReadLine();
        }
    }

}
