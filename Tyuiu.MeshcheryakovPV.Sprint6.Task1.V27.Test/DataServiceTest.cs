using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MeshcheryakovPV.Sprint6.Task1.V27.Lib;

namespace Tyuiu.MeshcheryakovPV.Sprint6.Task1.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidArrayCalculate()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;
            double[] array = new double[-startValue + stopValue + 1];
            array[0] = 19.81;
            array[1] = 16.79;
            array[2] = 13.86;
            array[3] = 10.97;
            array[4] = 7.93;
            array[5] = 3;
            array[6] = 3.22;
            array[7] = -0.45;
            array[8] = -3.79;
            array[9] = -6.96;
            array[10] = -9.99;

            double[] checkArray = ds.GetMassFunction(startValue, stopValue);


        }
    }
}
