using System.Globalization;
using System.Text.RegularExpressions;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.SlokvaGA.Sprint5.Task7.V11.Lib
{
    public class DataService : ISprint5Task7V11
    {
        public string LoadDataAndSave(string path)
        {
            string content = File.ReadAllText(path);
            string result = new string(content.Where(c => !(c >= 'а' && c <= 'я' || c == 'ё')).ToArray());

            result = System.Text.RegularExpressions.Regex.Replace(result, @"\s+", " ");
            result = result.Replace(", ?", ",?");

            int index = result.IndexOf("О .");
            if (index != -1)
            {
                result = result.Remove(index, 3).Insert(index, "О.");
            }

            return result.Trim();
        }
    }
}
