using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSlerning.Chapter4
{
    public class Chapter4_1
    {
        public void reWrite()
        {
            //объявление массива

            int[] myArr = new int[5];
            Random random = new Random();

            for (int i = 0; i < myArr.Length; i++)
            {
                myArr[i] = random.Next(1,10);
            }
            //инициализация каждого элемента вручную

            //myArr[0] = 1;
            //myArr[1] = 15676;
            //myArr[2] = 1234;
            //myArr[3] = 154543;
            //myArr[4] = 155;

            foreach(int i in myArr)
            {
                Console.WriteLine(i);
            }
        }
    }
}
