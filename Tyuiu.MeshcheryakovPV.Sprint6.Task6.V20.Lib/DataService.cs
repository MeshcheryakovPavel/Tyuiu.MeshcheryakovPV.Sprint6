using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.MeshcheryakovPV.Sprint6.Task6.V20.Lib
{
    public class DataService : ISprint6Task6V20
    {
        public string CollectTextFromFile(string str, string path)
        {
            {
                string[] lines = str.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
                string result = "";

                foreach (string line in lines)
                {
                    string[] words = line.Split(' ');
                    if (words.Length > 1)
                    {
                        result += words[1] + " ";
                    }
                    else
                    {
                        result += " ";
                    }
                }

                return result.Trim();
            }
        }

    }
}
