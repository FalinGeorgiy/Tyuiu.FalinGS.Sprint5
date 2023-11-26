using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.FalinGS.Sprint5.Task1.V7.Lib;

namespace Tyuiu.FalinGS.Sprint5.Task1.V7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Выполнил: Фалин Г.С | ИИПб-23-1";
            Console.WriteLine("###########################################################################");
            Console.WriteLine("* Cпринт №5                                                               #");
            Console.WriteLine("* Задание №1                                                              #");
            Console.WriteLine("* Вариант №7                                                             #");
            Console.WriteLine("* Выполнил: Фалин Георгий Сергеевич / ИИПб-23-1                           #");
            Console.WriteLine("###########################################################################");
            Console.WriteLine("* Исходные данные:                                                        #");
            Console.WriteLine("###########################################################################");

            int startValue = -5;
            int stopValue = 5;


            DataService ds = new DataService();

            Console.WriteLine("startValue = " + startValue);
            Console.WriteLine("stopValue = " + stopValue);


            Console.WriteLine("###########################################################################");
            Console.WriteLine("* Result                                                                  #");
            Console.WriteLine("###########################################################################");

            string res = ds.SaveToFileTextData(startValue,stopValue);




            Console.WriteLine("FILE: " + res);
            Console.WriteLine("Done!");
            Console.ReadKey();
        }
    }
}
