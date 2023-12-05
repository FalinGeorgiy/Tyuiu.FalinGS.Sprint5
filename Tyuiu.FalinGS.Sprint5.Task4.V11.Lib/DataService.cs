﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint5;

using System.IO;

namespace Tyuiu.FalinGS.Sprint5.Task4.V11.Lib
{
    public class DataService : ISprint5Task4V11
    {
        public double LoadFromDataFile(string path)
        {
            double x = Convert.ToDouble(File.ReadAllText(path));

            return Math.Round(Math.Sin(x) + Math.Pow(x, 2) / 2, 3);
        }
    }
}
