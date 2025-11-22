using Tyuiu.SlokvaGA.Sprint5.Task5.V27.Lib;

namespace Tyuiu.SlokvaGA.Sprint5.Task5.V27.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint5\InPutDataFileTask5V27.txt";
            double result = ds.LoadFromDataFile(path);
            Assert.AreEqual(7.5, result, 0.001);
        }
    }
}
