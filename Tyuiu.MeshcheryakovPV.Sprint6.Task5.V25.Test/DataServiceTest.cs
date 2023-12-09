using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MeshcheryakovPV.Sprint6.Task5.V25.Lib;

namespace Tyuiu.MeshcheryakovPV.Sprint6.Task5.V25.Test
{
    [TestClass]
    public class DataServieTest
    {
        [TestMethod]
        public void ValidShaitanMachin()
        {
            DataService ds = new DataService();
            string path = @"C:\Users\pavel\source\repos\Tyuiu.MeshcheryakovPV.Sprint6\Tyuiu.MeshcheryakovPV.Sprint6.Task5.V25\bin\Debug\InPutFileTask5V25.txt";

            double[] res = ds.LoadFromDataFile(path);
            double[] wait = { -13, -19, -9.82, 13, 11.49, -9.71, 3.36, 14.52, 16, 13.66, 4.13, -0.11, 19, -17.36, 11, 11.28, -12, -12.35 };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}
