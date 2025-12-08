using Tyuiu.AtanaevRI.Sprint6.Task0.V30.Lib;
namespace Tyuiu.AtanaevRI.Sprint6.Task0.V30.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double wait = 7.348;

            double res = ds.Calculate(3);
            Assert.AreEqual(wait, res);
        }
    }
}
