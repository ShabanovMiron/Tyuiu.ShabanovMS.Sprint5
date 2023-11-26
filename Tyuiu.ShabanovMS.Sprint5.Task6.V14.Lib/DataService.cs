using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.ShabanovMS.Sprint5.Task6.V14.Lib
{
    public class DataService : ISprint5Task6V14
    {
        public int LoadFromDataFile(string path)
        {
            int res = 0;
            string line;
            using (StreamReader reader = new StreamReader(path)) 
            { 
                 while ((line = reader.ReadLine()) != null)
                {
                    for (int i = 0; i < line.Length; i++)
                    {
                        if (line[i] == ',' || line[i] == '.' || line[i] == '!' || line[i] == '?')
                        {
                            res++;
                        }
                    }
                }
                return res;
            }
        }
    }
}
