using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSlerning.Chapter4
{
    public class Chapter4_5
    {
        public void reWrite()
        {
            int[] mySortArray = { 4, 1, 2, 3, 5 };

            for (int i = 0; i < mySortArray.Length; i++)
                mySortArray[i] = mySort(mySortArray, i);

            Console.WriteLine("\nОтсортированный массив:\n");
            foreach (int i in mySortArray)
                Console.Write("\t" + i);
        }

        // передача массива в метод в качестве параметра
        // данный метод возвращает значение одного из индексов
        // отсортированного массива
        static int mySort(int[] sortArray, int i)
        {
            Array.Sort(sortArray);
            return sortArray[i];
        }
    }
}


/*
namespace CSlerning.Chapter4
{
    public class Chapter4_5
    {
        public void reWrite()
        {
            int[] mySortArray = { 4, 1, 2, 3, 5 };
            Array.Sort(mySortArray);

            Console.WriteLine("\nОтсортированный массив:\n");
            foreach (int i in mySortArray)
                Console.Write("\t" + i);
        }
    }
}
*/
