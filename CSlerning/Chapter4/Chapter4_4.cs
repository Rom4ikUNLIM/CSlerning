using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSlerning.Chapter4
{
    public class Chapter4_4
    {
        public void reWrite()
        {
            string[] arr2 = new string[5];
            //создаём массив типа string длинной 5
            Array myArr = Array.CreateInstance(typeof(string), 5);

            //инициализируем первые три поля массива
            myArr.SetValue("Name", 0);
            myArr.SetValue("Age", 1);
            myArr.SetValue("Adress", 2);

            //копируем массив с помощью метода Clone()
            string[] arr1 = (string[])myArr.Clone();

            foreach (string s in arr1)
                Console.WriteLine("\t" + s);

            //копируем с помощью метода Copy()
            Console.WriteLine();

            Array.Copy(myArr, arr2, myArr.Length);
            foreach (string s in arr2)
                Console.WriteLine("\t" + s);
        }
    }
}
