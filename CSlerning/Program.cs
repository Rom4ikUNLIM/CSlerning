using System;
using CSlerning.Chapter3;
using CSlerning.Chapter4;
using CSlerning.Chapter5;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSlearning
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\nУкажите номер параграфа в формате #.##:\n");
                string numberOfChaprer = Console.ReadLine();

                switch (numberOfChaprer)
                {

            //CHAPTER 3
                    case "3.2":
                        (new Chapter3_2()).reWrite();
                        break;
                    case "3.3":
                        (new Chapter3_3()).reWrite();
                        break;
                    case "3.4":
                        (new Chapter3_4()).reWrite();
                        break;
                    case "3.5":
                        (new Chapter3_5()).reWrite();
                        break;
                    case "3.6":
                        (new Chapter3_6()).reWrite();
                        break;
                    case "3.7":
                        (new Chapter3_7()).reWrite();
                        break;
                    case "3.8":
                        (new Chapter3_8()).reWrite();
                        break;
                    case "3.9":
                        (new Chapter3_9()).reWrite();
                        break;
                    case "3.10":
                        (new Chapter3_10()).reWrite();
                        break;
                    case "3.12":
                        (new Chapter3_12()).reWrite();
                        break;
                    case "3.13":
                        (new Chapter3_13()).reWrite();
                        break;
                    case "3.14":
                        (new Chapter3_14()).reWrite();
                        break;
                    case "3.15":
                        (new Chapter3_15()).reWrite();
                        break;
                    case "3.16":
                        (new Chapter3_16()).reWrite();
                        break;
                    case "3.17":
                        (new chapter3_17()).reWrite();
                        break;

            //CHAPTER 4
                    case "4.1":
                        (new Chapter4_1()).reWrite();
                        break;
                    case "4.2":
                        (new Chapter4_2()).reWrite();
                        break;
                    case "4.3":
                        (new Chapter4_3()).reWrite();
                        break;
                    case "4.4":
                        (new Chapter4_4()).reWrite();
                        break;
                    case "4.5":
                        (new Chapter4_5()).reWrite();
                        break;
                    case "4.5.1":
                        (new Chapter4_5_1()).reWrite();
                        break;
                    case "4.6":
                        (new Chapter4_6()).reWrite();
                        break;
                    case "4.7":
                        (new Chapter4_7()).reWrite();
                        break;
                    case "4.8":
                        (new Chapter4_8()).reWrite();
                        break;
                    case "4.9":
                        (new Chapter4_9()).reWrite();
                        break;
                    case "4.10":
                        (new Chapter4_10()).reWrite();
                        break;

            //CHAPTER 5
                    case "5.1":
                        (new Chapter5_1()).reWrite();
                        break;
                    case "5.2":
                        (new Chapter5_2()).reWrite();
                        break;
                    case "5.3":
                        (new Chapter5_3()).reWrite();
                        break;
                    case "5.4":
                        (new Chapter5_4()).reWrite();
                        break;
                    case "5.5":
                        (new Chapter5_5()).reWrite();
                        break;
                    //case "5.6":
                    //(new Chapter5_6()).reWrite();
                    //break;
                    case "5.7":
                        (new Chapter5_7()).reWrite();
                        break;
                    case "5.8":
                        (new Chapter5_8()).reWrite();
                        break;
                    case "5.9":
                        (new Chapter5_9()).reWrite();
                        break;
                    case "5.10":
                        (new Chapter5_10()).reWrite();
                        break;
                    case "5.11":
                        (new Chapter5_11()).reWrite();
                        break;
                    case "5.12":
                        (new Chapter5_12()).reWrite();
                        break;
                    case "5.13":
                        (new Chapter5_13(1)).reWrite(); //??????
                        break;
                    case "5.14":
                        (new Chapter5_14()).reWrite();
                        break;
                    case "5.15":
                        (new Chapter5_15()).reWrite();
                        break;
                    case "5.55":
                        (new Chapter5_55()).reWrite();
                        break;


                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nЧто-то пошло не так. Попробуйте еще раз!");
                        break;
                }
            }
        }
    }
}