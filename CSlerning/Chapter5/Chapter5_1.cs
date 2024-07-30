using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CSlerning.Chapter5
{
    public class Chapter5_1
    {
        public class UserInfo
        {
            //поля класса 
            public string Name, Surname;
            public byte Age;

            //метод выводящий в консоль контактную информацию 

            public void writeInConsoleInfo(string Name, string Surname, byte Age)
            {
                Console.WriteLine("Имя:{0} \nФамилия:{1} \nВозраст:{2}", Name, Surname, Age);
            }
        }

        public void reWrite()
        {
            UserInfo myInfo = new UserInfo();

            myInfo.Name = "Roman";
            myInfo.Surname = "Balymov";
            myInfo.Age = 17;


            //выводим инфо в консоль

            myInfo.writeInConsoleInfo(myInfo.Name, myInfo.Surname, myInfo.Age);
        }

    }
}
 