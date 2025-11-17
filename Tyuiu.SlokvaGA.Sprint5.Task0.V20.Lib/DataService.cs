using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.SlokvaGA.Sprint5.Task0.V20.Lib
{
    public class DataService : ISprint5Task0V20
    {
        public string SaveToFileTextData(int x)
        {
            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask0.txt";
            double exp = (2.12*Math.Pow(2,3) + 1.05*Math.Pow(2,2) + 4.1*2*2);
            exp = Math.Round(exp, 3);
            string res = exp.ToString().Replace(".", ",");
            File.WriteAllText(path, res);
            return path;
        }
    }
}
