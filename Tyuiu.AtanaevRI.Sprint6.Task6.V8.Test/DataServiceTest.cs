using Tyuiu.AtanaevRI.Sprint6.Task6.V8.Lib;
namespace Tyuiu.AtanaevRI.Sprint6.Task6.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string testFilePath = "testfile.txt";
            string testContent = "HqrXl jNJC VLjXpq PAlR NnhEZ MNfYeB TwlB vpZoG RwZn qdsTS RizdogMOZpCb GGLDMUi AWkgYPxilmC GqzgGQOdWpd fPF NR ztMvvn XVZeHq HIwMbmO pvjFv MvGuVH BsmobjdwMQ VkNPKjfSHmgKrU";

            File.WriteAllText(testFilePath, testContent);

            DataService ds = new DataService();
            string result = ds.CollectTextFromFile(testFilePath);

            File.Delete(testFilePath);

            string expectedResult = "HqrXl jNJC  PAlR  TwlB vpZoG RwZn qdsTS   fPF NR ztMvvn  HIwMbmO pvjFv  BsmobjdwMQ  VkNPKjfSHmgKrU";
            Assert.AreEqual(expectedResult, result);
        }
    }
}
