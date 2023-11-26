using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.FalinGS.Sprint5.Task0.V6.Lib
{
    public class DataService : ISprint5Task0V6
    {
        public string SaveToFileTextData(int x)
        {
            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask0.txt";
            double z = (3 / (Math.Sqrt((Math.Pow(3, 2) + 3))));
            z = Math.Round(z, 3);


            File.WriteAllText(path, Convert.ToString(z));
            return path;
        }
    }
}
