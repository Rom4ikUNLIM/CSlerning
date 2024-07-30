using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSlerning.Chapter5
{
    public class Chapter5_3
    {

        public class Auto
        {
            public string marka;
        }

        public void reWrite()
        {
            Auto Car1 = new Auto();
            Auto Car2 = new Auto();

            Car1.marka = "BMW";
            Car2.marka = "Audi";

            Console.WriteLine("Марка 1й машины {0}\nМарка 2й машины {1}", Car1.marka, Car2.marka);
        }
    }
}