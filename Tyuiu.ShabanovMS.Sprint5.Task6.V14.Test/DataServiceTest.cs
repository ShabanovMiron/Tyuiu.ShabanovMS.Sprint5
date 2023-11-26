using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.ShabanovMS.Sprint5.Task6.V14.Lib;
namespace Tyuiu.ShabanovMS.Sprint5.Task6.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckExitstsFile()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask6V14.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(fileExists, wait);
        }

        [TestMethod]
        public void ValidCalc()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask6V14.txt";
            DataService ds = new DataService();
            var res = ds.LoadFromDataFile(path);
            var wait = 4;
            Assert.AreEqual(res, wait);
        }
    }
}
