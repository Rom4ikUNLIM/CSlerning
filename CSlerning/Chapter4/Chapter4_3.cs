namespace CSlerning.Chapter4
{
    public class Chapter4_3
    {
        public void reWrite()
        {
            int i = 0;
            //объявляем ступенчатый массив
            int[][] myArr = new int[4][];
            myArr[0] = new int[4];
            myArr[1] = new int[6];
            myArr[2] = new int[3];
            myArr[3] = new int[4];

            //инициальзуем ступенчатый массив
            for (i = 0; i < myArr[0].Length; i++)
            {
                myArr[0][i] = i;
                Console.Write("{0}\t", myArr[0][i]);
            }

            Console.WriteLine();
            for (i = 0; i < myArr[1].Length; i++)
            {
                myArr[1][i] = i;
                Console.Write("{0}\t", myArr[1][i]);
            }

            Console.WriteLine();
            for (i = 0; i < 3; i++)
            {
                myArr[2][i] = i;
                Console.Write("{0}\t", myArr[2][i]);
            }

            Console.WriteLine();
            for (i = 0; i < 4; i++)
            {
                myArr[3][i] = i;
                Console.Write("{0}\t", myArr[3][i]);
            }
        }
    }
}
