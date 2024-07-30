using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSlerning.Chapter3
{
    public class Chapter3_14
    {
        public void reWrite()
        {
            Console.WriteLine("Введите язык(C#, VB или C++)");
            string myLanguage = Console.ReadLine();

            switch (myLanguage)
            {
                case "C#":
                    Console.WriteLine("Вы выбрали C#");
                    break;
                case "VB":
                    Console.WriteLine("Вы выбрали VB");
                    break;
                case "C++":
                    Console.WriteLine("Вы выбрали C++");
                    break;
                default:
                    Console.WriteLine("Такой язык я не знаю");
                    break;
            }
        }

        
    }
}
