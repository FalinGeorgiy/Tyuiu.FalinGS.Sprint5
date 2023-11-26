using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.FalinGS.Sprint5.Task0.V6.Lib;

namespace Tyuiu.FalinGS.Sprint5.Task0.V6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Title = "Спринт #5 | Выполнил: Фалин Г.С | ИИПб-23-1";
            Console.WriteLine("###########################################################################");
            Console.WriteLine("* Cпринт №5                                                               #");
            Console.WriteLine("* Задание №0                                                              #");
            Console.WriteLine("* Вариант №6                                                             #");
            Console.WriteLine("* Выполнил: Фалин Георгий Сергеевич / ИИПб-23-1                           #");
            Console.WriteLine("###########################################################################");
            Console.WriteLine("* Исходные данные:                                                        #");
            Console.WriteLine("###########################################################################");

            DataService ds = new DataService();

            int x = 3;
            Console.WriteLine("X = 3 ");




            Console.WriteLine("###########################################################################");
            Console.WriteLine("* Result                                                                  #");
            Console.WriteLine("###########################################################################");

            string res = ds.SaveToFileTextData(x);
            



            Console.WriteLine("FILE: " + res);
            Console.WriteLine("Done!");
            Console.ReadKey();






        }
    }
}
