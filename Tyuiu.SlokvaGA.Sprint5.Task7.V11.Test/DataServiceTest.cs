using Tyuiu.SlokvaGA.Sprint5.Task7.V11.Lib;

namespace Tyuiu.SlokvaGA.Sprint5.Task7.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadFromDataFile()
        {
            string testContent = "Привет, как дела? Он написал письмо. Он ссорился с другом вчера.";
            string expected = "П,?О.О.";

            string tempPath = Path.GetTempFileName();
            File.WriteAllText(tempPath, testContent);

            DataService ds = new DataService();
            string result = ds.LoadDataAndSave(tempPath);

            File.Delete(tempPath);

            Assert.AreEqual(expected, result);
        }
    }
}
