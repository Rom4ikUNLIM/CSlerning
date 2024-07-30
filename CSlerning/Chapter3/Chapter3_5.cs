using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSlerning.Chapter3
{
    public class Chapter3_5
    {
        public void reWrite()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.Write(" {0}", i);
            } // здесь i покидает область видимости
            Console.WriteLine();

            // мы можем вновь объявить i
            for (int i = 0; i > -10; i--)
            {
                Console.Write(" {0}", i);
            } // i снова покидает область видимости


            //var j = i * i;  // данный код не выполнится, т.к  i не определена в текущем контексте
        }
    }
}
