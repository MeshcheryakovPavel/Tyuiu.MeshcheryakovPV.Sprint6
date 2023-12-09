﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MeshcheryakovPV.Sprint6.Task4.V23.Lib;

namespace Tyuiu.MeshcheryakovPV.Sprint6.Task4.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();
            int start = 0;
            int stop = 1;
            int len = 2;
            double[] array;
            array = new double[len];

            array[0] = 2;
            array[1] = -0.74;

            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(start, stop);
            CollectionAssert.AreEqual(array, res);
        }
    }
}