using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.VdovichenkoAI.Sprint6.Task7.V13.Lib;

namespace Tyuiu.VdovichenkoAI.Sprint6.Task7.V13.Test
{
    [TestClass]
    public class DataSerivceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\DataSprint6\InPutFileTask7V13.csv";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
