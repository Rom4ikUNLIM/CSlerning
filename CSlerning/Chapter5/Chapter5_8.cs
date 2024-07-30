using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSlerning.Chapter5
{
    public class Chapter5_8
    {
        public byte a;
        private byte b; //закрытый член, указанный явно
        byte c; //закрытый член по умолчанию

        public Chapter5_8() { }
        public Chapter5_8(byte x, byte y, byte z) 
        {
            a = x;  
            b = y;
            c = z;
        }


        public void rewrite()
        {
            Console.WriteLine("Закрытый член b = "+b);
        }

        public void reWrite()
        {
            Chapter5_8 obj = new Chapter5_8();
            obj.a = 10;
            //obj.b = 5;
            //obj.c = 2; данные операции недопустимы

            Chapter5_8 obj1 = new Chapter5_8(10,5,2);
            obj1.rewrite();
        }
    }


}
