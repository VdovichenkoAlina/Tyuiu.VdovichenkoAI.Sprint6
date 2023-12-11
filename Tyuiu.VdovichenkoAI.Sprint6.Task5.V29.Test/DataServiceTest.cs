using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.VdovichenkoAI.Sprint6.Task5.V29.Lib;

namespace Tyuiu.VdovichenkoAI.Sprint6.Task5.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = @"C:\Users\Администратор\source\repos\Tyuiu.VdovichenkoAI.Sprint6\Tyuiu.VdovichenkoAI.Sprint6.Task5.V29\bin\Debug\InPutFileTask5V29.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            Assert.AreEqual(true, fileExists);
        }
    }
}
