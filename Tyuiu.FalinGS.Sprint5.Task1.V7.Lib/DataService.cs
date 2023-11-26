using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.FalinGS.Sprint5.Task1.V7.Lib
{
    public class DataService : ISprint5Task1V7
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask1.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            double y;
            string strY;

            for (int x = startValue; x <= stopValue; x++)
            {
                y = (Math.Sin(x) / x + 1.2) - (Math.Sin(x) * 2) - (2 * x);
                strY = Convert.ToString(y);


                if (x!=stopValue)
                {
                    File.AppendAllText(path,strY + Environment.NewLine);

                }
                
                else
                {
                    File.AppendAllText(path, strY);
                }
            }
            return path;

        }
    }
}
