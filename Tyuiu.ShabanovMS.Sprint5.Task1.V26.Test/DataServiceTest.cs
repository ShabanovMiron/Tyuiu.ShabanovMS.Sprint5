using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.ShabanovMS.Sprint5.Task1.V26.Lib;
namespace Tyuiu.ShabanovMS.Sprint5.Task1.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidSave()
        {
            string path = @"C:\Users\Мирон\source\repos\Tyuiu.ShabanovMS.Sprint5\Tyuiu.ShabanovMS.Sprint5.Task1.V26\bin\Debug\OutPutFileTask1.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(fileExists, wait);
        }
    }
}
