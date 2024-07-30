using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSlerning.Chapter5
{
    public class Chapter5_12
    {

        static class MyMath
        {
            //целая часть числа
            static public int round(double d)
            {
                return (int)d;
            }

            //дробная часть числа
            static public double doub(double d)
            {
                return d - (int)d;
            }

            //квадрат числа
            static public double sqr(double d)
            {
                return d * d;
            }

            //квадратный корень числа
            static public double sqrt(double d)
            {
                return Math.Sqrt(d);
            }
        }

        public void reWrite()
        { 
            Console.WriteLine("Введите число: ");
            double d = double.Parse(Console.ReadLine());


            Console.WriteLine("Исходное число: {0}\n\n--------------------\n", d);
            Console.WriteLine("Целая часть: {0}", MyMath.round(d));
            Console.WriteLine("Дробная часть числа: {0}", MyMath.doub(d));
            Console.WriteLine("Квадрат числа: {0:#.##}", MyMath.sqr(d));
            Console.WriteLine("Квадратный корень числа: {0:#.###}", MyMath.sqrt(d));
        }
    }
}
