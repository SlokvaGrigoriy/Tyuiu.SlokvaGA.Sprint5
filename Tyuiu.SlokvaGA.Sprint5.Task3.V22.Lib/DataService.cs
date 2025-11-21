using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.SlokvaGA.Sprint5.Task3.V22.Lib
{
    public class DataService : ISprint5Task3V22
    {
        public string SaveToFileTextData(int x)
        {
            string tempPath = Path.GetTempPath();
            string fileName = "OutPutFileTask3.bin";
            string filePath = Path.Combine(tempPath, fileName);
            
            double y = Math.Round(Math.Pow(1 - x, 2) / (-3 * x), 3);

            byte[] binData = BitConverter.GetBytes(y);

            File.WriteAllBytes(filePath, binData);

            return filePath;
        }
    }
}
