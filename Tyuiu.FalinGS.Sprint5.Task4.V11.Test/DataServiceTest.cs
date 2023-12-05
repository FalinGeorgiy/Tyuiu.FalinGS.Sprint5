using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.FalinGS.Sprint5.Task4.V11.Lib;



namespace Tyuiu.FalinGS.Sprint5.Task4.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void FileExists()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask4V11.txt";
            FileInfo fileInfo = new FileInfo(path);
            Assert.AreEqual(true, fileInfo.Exists);
        }

        [TestMethod]
        public void ValidCalculate()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask4V11.txt";
            DataService ds = new DataService();
            Assert.AreEqual(3.913, ds.LoadFromDataFile(path));
        }
    }
}
