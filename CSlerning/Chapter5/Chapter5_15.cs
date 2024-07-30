using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSlerning.Chapter5
{
    public class Chapter5_15
    {
        int age;

        public int Age
        {
            get
            {
                return age;
            }
            private set
            {
                age = value;
            }
        }

        public int myAge()
        {
            //внутри класса доступ открыт
            Age = 26;
            return Age;
        }

        public void reWrite()
        {
            Chapter5_15 ui = new Chapter5_15();
            ui.myAge();

            // Для чтения доступ открыт вне класса
            Console.WriteLine(ui.Age);
            /* 
             * Так нельзя:
             * ui.Age = 26;
             * UserInfo ui1 = new UserInfo{ Age = 26 };
             */

        }
    }
}
