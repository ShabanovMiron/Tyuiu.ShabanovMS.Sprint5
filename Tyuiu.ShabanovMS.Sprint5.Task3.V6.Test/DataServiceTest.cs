﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ShabanovMS.Sprint5.Task3.V6.Lib;
using System.IO;
namespace Tyuiu.ShabanovMS.Sprint5.Task3.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExists()
        {
            string path = @"C:\Users\Мирон\source\repos\Tyuiu.ShabanovMS.Sprint5\Tyuiu.ShabanovMS.Sprint5.Task3.V6\bin\Debug\OutPutFileTask3.bin";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(fileExists, wait);
        }
    }
}
