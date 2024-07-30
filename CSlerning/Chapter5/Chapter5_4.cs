using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CSlerning.Chapter5
{
    public class Chapter5_4
    {
            double r;
            string s;

            //возвращаем площадь круга
            double sqrCircle()
            {
                return Math.PI * r * r;
            }

            //возвращаем длинну окружности
            double longCircle()
            {
                return 2 * Math.PI * r;
            }

        public void reWrite()
        {
            Console.WriteLine("Введите радиус: ");
            string radius = Console.ReadLine();

            Chapter5_4 newOperation = new Chapter5_4 { r = double.Parse(radius) };


            Console.WriteLine("Вычисляем площадь круга или его длинну? s/l?");
            s = Console.ReadLine();
            s = s.ToLower();

            if (s == "s")
            {
                Console.WriteLine("Площадь круга равна {0:#.###}", newOperation.sqrCircle());
            }
            else if (s == "l")
            {
                Console.WriteLine("Длинна круга равна {0:#.##}", newOperation.longCircle());
            }
            else
            {
                Console.WriteLine("Вы ввели не тот символ");
            }
        }
    }
}
