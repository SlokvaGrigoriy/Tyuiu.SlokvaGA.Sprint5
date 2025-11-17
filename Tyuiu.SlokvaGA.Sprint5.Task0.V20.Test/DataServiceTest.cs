using Tyuiu.SlokvaGA.Sprint5.Task0.V20.Lib;

namespace Tyuiu.SlokvaGA.Sprint5.Task0.V20.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            DataService ds = new DataService();
            string path = @"C:\Users\Input\source\repos\Tyuiu.SlokvaGA.Sprint5\Tyuiu.SlokvaGA.Sprint5.Task0.V20\bin\Debug\OutPutFileTask0.txt";
            int x = 2;
            string fp = ds.SaveToFileTextData(x);
            Assert.IsTrue(File.Exists(fp));
            string wait = File.ReadAllText(fp);
            double res = double.Parse(wait);
            Assert.AreEqual(0.866, res, 0.001);
        }
    }
}
