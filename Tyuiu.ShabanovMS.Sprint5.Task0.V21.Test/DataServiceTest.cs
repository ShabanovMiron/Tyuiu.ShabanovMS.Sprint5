using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ShabanovMS.Sprint5.Task0.V21.Lib;
using System.IO;
namespace Tyuiu.ShabanovMS.Sprint5.Task0.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidSave()
        {
            string path = @"C:\Users\Мирон\source\repos\Tyuiu.ShabanovMS.Sprint5\Tyuiu.ShabanovMS.Sprint5.Task0.V21\bin\Debug\OutPutFileTask0.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(fileExists, wait);
        }
    }
}
