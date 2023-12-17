using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.VdovichenkoAI.Sprint6.Task6.V27.Lib;

namespace Tyuiu.VdovichenkoAI.Sprint6.Task6.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string str = "H";
            string path = @"C:\DataSprint6\InPutFileTask6V27.txt";
            string wait = "UpGwjzkBH OHcr KgepHrKCHa";
            string res = ds.CollectTextFromFile(path);
            Assert.AreEqual(wait, res);
        }
    }
}
