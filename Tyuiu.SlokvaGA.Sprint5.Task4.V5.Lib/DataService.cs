using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.SlokvaGA.Sprint5.Task4.V5.Lib
{
    public class DataService : ISprint5Task4V5
    {
        public double LoadFromDataFile(string path)
        {
            string content = File.ReadAllText(path);
            content = content.Trim();
            double x = double.Parse(content, CultureInfo.InvariantCulture);
            double y = Math.Round(4.26 * x / Math.Sin(x), 3);
            return y;
        }
    }
}
