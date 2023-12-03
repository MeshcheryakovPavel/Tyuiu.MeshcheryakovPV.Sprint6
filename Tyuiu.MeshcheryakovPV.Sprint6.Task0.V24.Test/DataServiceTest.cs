using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MeshcheryakovPV.Sprint6.Task0.V24.Lib;

namespace Tyuiu.MeshcheryakovPV.Sprint6.Task0.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            int x = 3;
            var wait = 1024;
            var res = ds.Calculate(x);
            Assert.AreEqual(wait, res);
        }
    }
}
