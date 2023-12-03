using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.MeshcheryakovPV.Sprint6.Task2.V14.Lib
{
    public class DataService : ISprint6Task2V14
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueA;
            int len = (stopValue - startValue) + 1;
            valueA = new double[len];
            double y;
            int i = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                if ((Math.Cos(x) + 1) == 0)
                {
                    y = 0;
                    valueA[i] = y;
                    i++;
                }
                y = Math.Round((5 - 3* x) + ((1 + Math.Cos(x)) / (2 * x - 0.5)), 2);
                valueA[i] = y;
                i++;
            }
            return valueA;
        }
    }
}