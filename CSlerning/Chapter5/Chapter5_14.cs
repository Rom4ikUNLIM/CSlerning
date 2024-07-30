using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSlerning.Chapter5
{
    public class Chapter5_14
    {
        int a;
        string s = "Alex";

        //создадим свойство, управляющее доступом к переменной а
        public int Age
        {
            get
            {
                if (a <= 0)
                    return 1;
                return a;
            }

            set
            {
                a = value;
            }
        }

        //свойство только для чтения переменной s 
        //аксессор set отсутствует
        public string Name
        {
            get
            {
                return s;
            }
        }

        public void reWrite()
        {
            Chapter5_14 ui = new Chapter5_14();

            //доступ к закрытой переменной экземпляра только через свойство
            ui.Age = 26;
            //переменная только для чтения 
            string myName = ui.Name;
        }
    }
}
