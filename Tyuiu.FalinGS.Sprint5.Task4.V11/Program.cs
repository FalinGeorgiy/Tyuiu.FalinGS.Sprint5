using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.FalinGS.Sprint5.Task4.V11.Lib;


namespace Tyuiu.FalinGS.Sprint5.Task4.V11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Фалин Г.С | ИИПб-23-1";
            Console.WriteLine("###########################################################################");
            Console.WriteLine("* Cпринт №5                                                               #");
            Console.WriteLine("* Задание №4                                                              #");
            Console.WriteLine("* Вариант №11                                                             #");
            Console.WriteLine("* Выполнил: Фалин Георгий Сергеевич / ИИПб-23-1                           #");
            Console.WriteLine("###########################################################################");
            Console.WriteLine("* Исходные данные:                                                        #");
            Console.WriteLine("###########################################################################");

            string path = @"C:\DataSprint5\InPutDataFileTask4V11.txt";


            Console.WriteLine("Dannie nahodyatsya v file: " + path);


            

            Console.WriteLine("###########################################################################");
            Console.WriteLine("* Result                                                                  #");
            Console.WriteLine("###########################################################################");

            double res = ds.LoadFromDataFile(path);


            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
