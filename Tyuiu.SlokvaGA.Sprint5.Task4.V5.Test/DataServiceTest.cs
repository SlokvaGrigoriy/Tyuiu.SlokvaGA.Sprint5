using Tyuiu.SlokvaGA.Sprint5.Task4.V5.Lib;

namespace Tyuiu.SlokvaGA.Sprint5.Task4.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint5\InPutDataFileTask4V5.txt";
            double result = ds.LoadFromDataFile(path);
            Assert.AreEqual(-127.963, result, 0.001);
        }
    }
}
