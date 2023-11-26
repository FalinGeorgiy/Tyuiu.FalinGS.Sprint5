using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

using Tyuiu.FalinGS.Sprint5.Task0.V6.Lib;

namespace Tyuiu.FalinGS.Sprint5.Task0.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {

            string path = @"C:\Users\User\source\repos\Tyuiu.FalinGS.Sprint5\Tyuiu.FalinGS.Sprint5.Task0.V6\bin\Debug\OutPutFileTask0.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);

        }
    }
}
