using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.AtanaevRI.Sprint6.Task2.V17.Lib;

namespace Tyuiu.AtanaevRI.Sprint6.Task2.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            double[] res = ds.GetMassFunction(startValue, stopValue);

            double[] wait = { 15.19, 11.67, 8.04, 4.33, 0.54, -3, -6.04, -8.33, -9.46, -8.93, -6.16 };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}