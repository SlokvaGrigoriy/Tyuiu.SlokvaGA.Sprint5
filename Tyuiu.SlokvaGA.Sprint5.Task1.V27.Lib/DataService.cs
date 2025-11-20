using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.SlokvaGA.Sprint5.Task1.V27.Lib
{
    public class DataService : ISprint5Task1V27
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string tempPath = Path.GetTempPath();
            string fileName = "OutPutFileTask1.txt";
            string filePath = Path.Combine(tempPath, fileName);
            string fileContent = "";

            for (int x = startValue; x <= stopValue; x++)
            {
                double fx = 0.0;

                double denominator = Math.Sin(x)-3+x;

                if (denominator == 0)
                {
                    fx = 0.0;
                }
                else
                {
                    fx = (-3*x-1.5/ Math.Sin(x)-3+x) + 2;
                }

                fx = Math.Round(fx, 2);
                fileContent += fx.ToString() + "\n";
            }

            File.WriteAllText(filePath, fileContent);

            return filePath;
        }
    }
}
