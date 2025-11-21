using Tyuiu.SlokvaGA.Sprint5.Task2.V8.Lib;

namespace Tyuiu.SlokvaGA.Sprint5.Task2.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            DataService ds = new DataService();

            int[,] array = {
                {9, 4, -6},
                {3, 9, 9},
                {-6, 7, -4}
            };

            string filePath = ds.SaveToFileTextData(array);

            Assert.IsTrue(File.Exists(filePath));

            string content = File.ReadAllText(filePath);
            string expected = "1;1;0\n1;1;1\n0;1;0";

            Assert.AreEqual(expected, content);
        }
    }
}