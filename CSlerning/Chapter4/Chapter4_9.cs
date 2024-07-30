using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSlerning.Chapter4
{
    public class Chapter4_9
    {
        public void reWrite()
        {
            DateTime myDate = DateTime.Now;
            Console.WriteLine("Дата в формате d: {0:d}\nВ формате D: {0:D}", myDate);
            Console.WriteLine("Дата в формате f: {0:f}\nВ формате F: {0:F}", myDate);
            Console.WriteLine("Дата в формате g: {0:g}\nВ формате G: {0:G}", myDate);
            Console.WriteLine("Дата в формате m: {0:m}\nВ формате M: {0:M}", myDate);
            Console.WriteLine("Дата в формате r: {0:r}\nВ формате R: {0:R}", myDate);
            Console.WriteLine("Дата в формате o: {0:o}\nВ формате O: {0:O}", myDate);
            Console.WriteLine("Дата в формате s: {0:s}", myDate);
            Console.WriteLine("Дата в формате t: {0:t}\nВ формате T: {0:T}", myDate);
            Console.WriteLine("Дата в формате u: {0:u}\nВ формате U: {0:U}", myDate);
            Console.WriteLine("Дата в формате y: {0:y}\nВ формате Y: {0:Y}", myDate);
        }
    }
}
