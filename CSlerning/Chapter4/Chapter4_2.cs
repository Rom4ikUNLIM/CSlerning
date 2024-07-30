using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSlerning.Chapter4
{
    public class Chapter4_2
    {
        public void reWrite()
        {
            //объявляем двумерный массив
            int[,] myArr = new int[4, 5];
            Random random = new Random();

            //инициализируем данный массив 
            for (int i = 0; i < 4; i++){
                for (int j = 0; j < 5; j++)
                {
                    myArr[i, j] = random.Next(1, 60);
                    Console.WriteLine("{0}\t", myArr[i, j]);
                }
            }



            //трехмерный массив
            //int[,,] myArr = new int[5, 5, 5];

            //for (int i = 0; i < 5; i++)
               //for (int j = 0; j < 5; j++)
                    //for (int k = 0; k < 5; k++)
                        //myArr[i, j, k] = i + j + k;


        }
    }
}
