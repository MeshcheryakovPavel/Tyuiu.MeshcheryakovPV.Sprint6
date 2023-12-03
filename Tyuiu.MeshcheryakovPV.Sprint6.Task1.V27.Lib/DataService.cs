using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;


namespace Tyuiu.MeshcheryakovPV.Sprint6.Task1.V27.Lib
{

    public class DataService : ISprint6Task1V27
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] array = new double[-startValue + stopValue + 1];
            for (int i = 0, x = startValue; x <= stopValue; x++, i++)
            {
                array[i] = Math.Round((4 - 2 * x ) + ((2+ Math.Cos(x) / 2*x-2)), 2);
            }

            return array;
        }
    }
}


