using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSlerning.Chapter3
{
    public class Chapter3_6
    {
        public void reWrite()
        {
            //Расчет стоимости капиталовложения с фиксированной нормой прибыли
            decimal money, percent;
            int i;
            const byte years = 15;

            money = 1000.0m;
            percent = 0.045m;

            for (i = 1; i <= years; i++)
            {
                money *= 1 + percent;
            }

            Console.WriteLine("Общий доход за {0} лет: {1} $$", years, money);
        }
    }
}
