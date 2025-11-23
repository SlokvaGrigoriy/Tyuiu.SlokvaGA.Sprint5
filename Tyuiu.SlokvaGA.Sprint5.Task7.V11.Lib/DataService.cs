using System.Globalization;
using System.Text.RegularExpressions;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.SlokvaGA.Sprint5.Task7.V11.Lib
{
    public class DataService : ISprint5Task7V11
    {
        public string LoadDataAndSave(string path)
        {
            string str = File.ReadAllText(path);
            string result = "";

            foreach (char c in str)
            {
                if ((c >= 'а' && c <= 'я') || c == 'ё')
                {
                    continue;
                }

                result += c;
            }

            result = System.Text.RegularExpressions.Regex.Replace(result, @"\s+", " ");

            result = result.Replace(" , ?", ",?")
                           .Replace("О .", "О.")
                           .Replace("О .", "О.")
                           .Trim();

            return result;
        }
    }
}
