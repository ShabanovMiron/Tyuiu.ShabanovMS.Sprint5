﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ShabanovMS.Sprint5.Task7.V10.Lib;
using System.IO;
namespace Tyuiu.ShabanovMS.Sprint5.Task7.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckExitstsFile()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask7V10.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(fileExists, wait);
        }
    }
}
