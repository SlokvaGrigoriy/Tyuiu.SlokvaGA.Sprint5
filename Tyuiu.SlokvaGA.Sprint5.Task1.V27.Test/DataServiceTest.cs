using Tyuiu.SlokvaGA.Sprint5.Task1.V27.Lib;

namespace Tyuiu.SlokvaGA.Sprint5.Task1.V27.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;

            string filePath = ds.SaveToFileTextData(startValue, stopValue);

            Assert.IsTrue(File.Exists(filePath));

            string content = File.ReadAllText(filePath);
            string[] lines = content.Split('\n', StringSplitOptions.RemoveEmptyEntries);

            Assert.AreEqual(11, lines.Length);

            double firstValue = double.Parse(lines[0]);
            Assert.AreEqual(4.34, firstValue, 0.01);
        }
    }
}
