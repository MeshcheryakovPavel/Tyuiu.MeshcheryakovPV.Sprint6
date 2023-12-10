using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MeshcheryakovPV.Sprint6.Task6.V20.Lib;

namespace Tyuiu.MeshcheryakovPV.Sprint6.Task6.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\pavel\source\repos\Tyuiu.MeshcheryakovPV.Sprint6\Tyuiu.MeshcheryakovPV.Sprint6.Task6.V20\bin\Debug\InPutFileTask6V20.txt";
            string res = ds.CollectTextFromFile(path);
            string wait = " sotJJI  WshlXoIXuhTf DvbkNN";
            Assert.AreEqual(wait, res);
        }
    }
}
