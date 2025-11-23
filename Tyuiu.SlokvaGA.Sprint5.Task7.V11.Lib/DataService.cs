using System.Globalization;
using System.Text.RegularExpressions;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.SlokvaGA.Sprint5.Task7.V11.Lib
{
    public class DataService : ISprint5Task6V27
    {
        public int LoadFromDataFile(string path)
        {
            string content = File.ReadAllText(path);
            int count = 0;
            int currentDigits = 0;

            foreach (char c in content)
            {
                if (c >= '0' && c <= '9')
                {
                    currentDigits++;
                }
                else
                {
                    if (currentDigits == 3) count++;
                    currentDigits = 0;
                }
            }

            if (currentDigits == 3) count++;
            return count;
        }
    }
}
