using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSlerning.Chapter5
{

    public class another
    {
        public string Name;
        public byte Age;

        //создаём параметрический конструктор
        public another(string s, byte b)
        {
            Name = s;
            Age = b;
        }

        public void write()
        {
            Console.WriteLine("Имя: {0}\nВозраст:{1}", Name, Age);
        }
    }

    public class Chapter5_5
    {
        public void reWrite()
        {
            another ex = new another("Roman", 17);
            ex.write();
        }
    }
}












