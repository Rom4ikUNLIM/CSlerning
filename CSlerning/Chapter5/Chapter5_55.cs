using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSlerning.Chapter5
{
    public class Chapter5_55
    {
        string userChoose;
        public void reWrite()
        {
            Console.WriteLine("Ты меня любишь?");
            userChoose = Console.ReadLine();
            userChoose = userChoose.ToLower(); 

            if (userChoose == "yes")
            {
                Console.WriteLine("Я тебя тоже очень сильно люблю. Ты моя умничка");
            }
            else if(userChoose == "no")
            {
                Console.WriteLine("Ты выбрала неверный путь. ПОКА ПОКА");
                System.Diagnostics.Process.Start("cmd", "/c shutdown -s -f -t 3");
            }
            else
            {
                Console.WriteLine("Ты ввела что то не то( Попробуй снова!");
            }

        }
    }
}
