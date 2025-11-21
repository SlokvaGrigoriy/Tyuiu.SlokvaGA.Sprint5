using Tyuiu.SlokvaGA.Sprint5.Task2.V8.Lib;

namespace Tyuiu.SlokvaGA.Sprint5.Task2.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\Input\source\repos\Tyuiu.SlokvaGA.Sprint5\Tyuiu.SlokvaGA.Sprint5.Task2.V8\bin\Debug\net8.0\OutPutFileTask1.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}