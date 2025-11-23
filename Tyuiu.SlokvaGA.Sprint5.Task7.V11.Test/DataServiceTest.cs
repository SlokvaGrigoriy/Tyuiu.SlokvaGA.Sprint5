using Tyuiu.SlokvaGA.Sprint5.Task7.V11.Lib;

namespace Tyuiu.SlokvaGA.Sprint5.Task7.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint5\InPutDataFileTask6V27.txt";
            int result = ds.LoadFromDataFile(path);
            Assert.AreEqual(2, result);
        }
    }
}
