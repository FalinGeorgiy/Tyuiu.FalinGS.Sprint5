using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.FalinGS.Sprint5.Task5.V1.Lib;

namespace Tyuiu.FalinGS.Sprint5.Task5.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadFromDataFile()
        {
            string path = @"C:\Users\User\source\repos\Tyuiu.FalinGS.Sprint5\Tyuiu.FalinGS.Sprint5.Task5.V1\bin\Debug\InPutDataFileTask5V1.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
