using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.SlokvaGA.Sprint5.Task5.V27.Lib
{
    public class DataService : ISprint5Task5V27
    {
        public double LoadFromDataFile(string path)
        {
            string content = File.ReadAllText(path);
            string[] numbers = content.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            List<double> divisibleNumbers = new List<double>();

            foreach (string numStr in numbers)
            {
                if (double.TryParse(numStr, out double number) && number % 5 == 0)
                {
                    divisibleNumbers.Add(Math.Round(number, 3));
                }
            }

            return divisibleNumbers.Count > 0 ? Math.Round(divisibleNumbers.Average(), 3) : 0;
        }
    }
}
