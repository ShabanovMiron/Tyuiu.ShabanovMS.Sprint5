using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ShabanovMS.Sprint5.Task2.V7.Lib;
using System.IO;
namespace Tyuiu.ShabanovMS.Sprint5.Task2.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\Мирон\source\repos\Tyuiu.ShabanovMS.Sprint5\Tyuiu.ShabanovMS.Sprint5.Task2.V7\bin\Debug\OutPutFileTask2.cvs";
            
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(fileExists, wait);
        }
    }
}
