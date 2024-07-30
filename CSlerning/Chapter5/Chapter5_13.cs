using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSlerning.Chapter5
{
    public class Chapter5_13
    {
        int[] arr;
        public int Length;

        public Chapter5_13(int Size)
        {
            arr = new int[Size];
            Length = Size;
        }

        //создаём простейший индексатор
        public int this[int index]
        {
            set
            {
                arr[index] = value;
            }

            get
            {
                return arr[index];
            }
        }

        public void reWrite()
        {
            Chapter5_13 arr1 = new Chapter5_13(Size: 5);
            Random ran = new Random();

            //инициалмзируем каждый индекс экземпляра класса arr1
            for(int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = ran.Next(1,200);
                Console.Write("{0}\t", arr1[i]);
            }
        }

    }
}
