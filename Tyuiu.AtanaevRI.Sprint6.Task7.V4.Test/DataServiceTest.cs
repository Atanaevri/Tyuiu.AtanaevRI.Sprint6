using Tyuiu.AtanaevRI.Sprint6.Task7.V4.Lib;
namespace Tyuiu.AtanaevRI.Sprint6.Task7.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\atana\source\repos\Tyuiu.AtanaevRI.Sprint6\Tyuiu.AtanaevRI.Sprint6.Task7.V4\bin\Debug\net8.0-windows\InPutDataFileTask7V4";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
