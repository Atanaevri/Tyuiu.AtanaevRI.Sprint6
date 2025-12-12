using Tyuiu.AtanaevRI.Sprint6.Task4.V4.Lib;
namespace Tyuiu.AtanaevRI.Sprint6.Task4.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            
                DataService ds = new DataService();

                double wait = -2.15;

                double[] res = ds.GetMassFunction(-5, 5);

                Assert.AreEqual(wait, res[0]);
            }
        }
    }

  

