using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MeshcheryakovPV.Sprint6.Task3.V5.Lib;

namespace Tyuiu.MeshcheryakovPV.Sprint6.Task3.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] matrix = new int[5, 5] { { 30, -20,   7,  -8,  9 },
 { 32,  17, -14 , -7 , 33 },
 { 19, -19, -13,  14 ,-20 },
 { 11,  30, -1,  26 ,  6},
 { 30 ,-15 ,-20 , -5 , 15}};
            int[,] res = ds.Calculate(matrix);
            int[,] wait = new int[5, 5] { { 30, -20,   7,  -8,  -20 }, 
 { 32,  17, -14 , -7 , 6 },
 { 19, -19, -13,  14 ,9 },
 { 11,  30, -1,  26 ,  15},
 { 30 ,-15 ,-20 , -5 , 33}};
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
