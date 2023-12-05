using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
using static System.Net.Mime.MediaTypeNames;
using System.Text.RegularExpressions;

namespace Tyuiu.FalinGS.Sprint5.Task7.V8.Lib
{
    public class DataService : ISprint5Task7V8
    {
        public string LoadDataAndSave(string path)
{
    string pathSaveFile = @"C:\Users\User\source\repos\Tyuiu.FalinGS.Sprint5\Tyuiu.FalinGS.Sprint5.Task7.V8\bin\Debug\OutPutDataFileTask7V8.txt";

    FileInfo fileInfo = new FileInfo(pathSaveFile);
    bool fileExists = fileInfo.Exists;

    if (fileExists)
    {
        File.Delete(pathSaveFile);
    }

    char[] alph = { 'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ё', 'Ж', 'З', 'И', 'Й', 'К', 'Л', 'М', 'Н', 'О', 'П', 'Р', 'С', 'Т', 'У', 'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ъ', 'Ы', 'Ь', 'Э', 'Ю', 'Я' };

    using (StreamReader reader = new StreamReader(path))
    {
        string strLine;
        while ((strLine = reader.ReadLine()) != null)
        {
            string processedLine = "";
            foreach (char c in strLine)
            {
                if (char.IsUpper(c) && (c >= 'А' && c <= 'Я'))
                {
                    processedLine += char.ToLower(c);
                }
                else
                {
                    processedLine += c;
                }
            }
            File.AppendAllText(pathSaveFile, processedLine + Environment.NewLine);
        }
    }

    return pathSaveFile;
}

    }
}
