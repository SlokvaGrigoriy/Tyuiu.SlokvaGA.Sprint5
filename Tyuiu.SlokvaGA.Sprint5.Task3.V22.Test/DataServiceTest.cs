using Tyuiu.SlokvaGA.Sprint5.Task3.V22.Lib;

namespace Tyuiu.SlokvaGA.Sprint5.Task3.V22.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            DataService ds = new DataService();

            int x = 5;

            string filePath = ds.SaveToFileTextData(x);

            Assert.IsTrue(File.Exists(filePath));

            using (BinaryReader reader = new BinaryReader(File.Open(filePath, FileMode.Open)))
            {
                double result = reader.ReadDouble();
                Assert.AreEqual(-114.5, result, 0.001);
            }
        }
    }
}
