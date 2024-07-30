using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSlerning.Chapter5
{
    public class Chapter5_2
    {
        public void reWrite()
        {
            var m = Environment.Version;
            Console.WriteLine("Тип m: {0}", m.GetType());

            string s = m.ToString();
            Console.WriteLine("Версия .NET Framework: {0}", s);

            Version v = (Version)m.Clone();
            Console.WriteLine("V: {0}", v);

            int hashcode = m.GetHashCode();
            Console.WriteLine("Хешкод:{0}", hashcode);

            var myOS = Environment.OSVersion;
            Console.WriteLine("Версия ОС:{0}", myOS);

            object[] myArr = { "Строка", 120, 0.345m, 2.34f, 'Z' };

            foreach (object obj in myArr)
                Console.WriteLine("Элемент \"{0}\"его тип - {1}", obj, obj.GetType());
        }
    }
}
