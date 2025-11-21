using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.SlokvaGA.Sprint5.Task2.V8.Lib
{
    public class DataService : ISprint5Task2V8
    {
        public string SaveToFileTextData(int[,] matrix)
        {
            string tempPath = Path.GetTempPath();
            string fileName = "OutPutFileTask2.csv";
            string filePath = Path.Combine(tempPath, fileName);
            string csvContent = "";

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    int value = matrix[i, j];
                    csvContent += (value > 0 ? 1 : 0).ToString();

                    if (j < 2) csvContent += ";";
                }
                if (i < 2) csvContent += "\n";
            }
            
            File.WriteAllText(filePath, csvContent);

            return filePath;
        }
    }
}