using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.ShabanovMS.Sprint5.Task1.V26.Lib
{
    public class DataService : ISprint5Task1V26
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask1.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            double res;
            string strRes;

            for (int x = startValue; x <= stopValue; x++)
            {
                res = Math.Round(((2 * x + 6) / (Math.Cos(x) + x)) - 3 ,2);
                strRes = Convert.ToString(res);

                if (x == 0)
                {
                    res = 0;
                    strRes = Convert.ToString(res);
                }

                if (x != stopValue)
                {
                    File.AppendAllText(path, strRes + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(path, strRes);
                }
            }

            return path;
        }
    }
}
