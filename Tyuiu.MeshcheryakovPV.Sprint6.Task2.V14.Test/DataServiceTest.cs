using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MeshcheryakovPV.Sprint6.Task2.V14.Lib;

namespace Tyuiu.MeshcheryakovPV.Sprint6.Task2.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidMassFunctio()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;
            int len = stopValue - startValue + 1;
            double[] valueWA = new double[len];
            valueWA[0] = 19.81;
            valueWA[1] = 16.79;
            valueWA[2] = 13.86;
            valueWA[3] = 10.97;
            valueWA[4] = 7.93;
            valueWA[5] = 3;
            valueWA[6] = 3.22;
            valueWA[7] = -0.45;
            valueWA[8] = -3.79;
            valueWA[9] = -6.96;
            valueWA[10] = -9.99;
            double[] res = new double[len];
            res = ds.GetMassFunction(startValue, stopValue);
         
        }
    }
}
