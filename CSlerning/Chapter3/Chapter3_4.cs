using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSlerning.Chapter3
{
    public class Chapter3_4
    {
        public void reWrite()
        {
            var name = "Roman Balymov";
            var age = 17;
            var isProgrammer = true;

            // Определяем тип переменных
            Type nameType = name.GetType();
            Type ageType = age.GetType();
            Type isProgrammerType = isProgrammer.GetType();

            // Выводим в консоль результаты
            Console.WriteLine("Тип name: {0}", nameType);
            Console.WriteLine("Тип age {0}", ageType);
            Console.WriteLine("Тип isProgrammer {0}", isProgrammerType);
        }
    }
}
