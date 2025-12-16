using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.AtanaevRI.Sprint6.Task6.V8.Lib;
using System.IO;

namespace Tyuiu.AtanaevRI.Sprint6.Task6.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCollectTextFromFile()
        {
            string path = @"C:\Test\InPutFileTask6V8.txt";

          
            string[] testData = {
                "The quick brown fox jumps over the lazy dog",
                "Zebra is an amazing animal from Africa",
                "In the zoo, you can see many animals",
                "Some words with z: puzzle, crazy, buzz, fuzzy, dizzy"
            };

            File.WriteAllLines(path, testData);

            DataService ds = new DataService();
            string result = ds.CollectTextFromFile(path);

         
            string expectedWords = "lazy puzzle crazy buzz fuzzy dizzy";

           
            Assert.IsTrue(result.Contains("lazy"));
            Assert.IsTrue(result.Contains("puzzle"));
            Assert.IsTrue(result.Contains("crazy"));
            Assert.IsTrue(result.Contains("buzz"));
            Assert.IsTrue(result.Contains("fuzzy"));
            Assert.IsTrue(result.Contains("dizzy"));

            
            StringAssert.Contains(result, " ");
   if (File.Exists(path))
                File.Delete(path);
        }

        [TestMethod]
        public void FileWithNoWordsContainingZ()
        {
            string path = @"C:\Test\NoZWords.txt";

            string[] testData = {
                "Hello world",
                "This is a test",
                "Programming in C#"
            };

            File.WriteAllLines(path, testData);

            DataService ds = new DataService();
            string result = ds.CollectTextFromFile(path);

            Assert.AreEqual(string.Empty, result);

            if (File.Exists(path))
                File.Delete(path);
        }

        [TestMethod]
        [ExpectedException(typeof(FileNotFoundException))]
        public void FileNotFoundTest()
        {
            DataService ds = new DataService();
            ds.CollectTextFromFile(@"C:\Nonexistent\file.txt");
        }

        [TestMethod]
        public void EmptyFileTest()
        {
            string path = @"C:\Test\EmptyFile.txt";
            File.WriteAllText(path, "");

            DataService ds = new DataService();
            string result = ds.CollectTextFromFile(path);

            Assert.AreEqual(string.Empty, result);

            if (File.Exists(path))
                File.Delete(path);
        }

        [TestMethod]
        public void CaseSensitiveTest()
        {
            string path = @"C:\Test\CaseTest.txt";

          
            string[] testData = {
                "zebra Zoo ZENITH",
                "amazing puzzle",
                "azure music"
            };

            File.WriteAllLines(path, testData);

            DataService ds = new DataService();
            string result = ds.CollectTextFromFile(path);

         
            Assert.IsTrue(result.Contains("zebra"));
            Assert.IsTrue(result.Contains("amazing"));
            Assert.IsTrue(result.Contains("puzzle"));
            Assert.IsTrue(result.Contains("azure"));

            Assert.IsFalse(result.Contains("Zoo"));
            Assert.IsFalse(result.Contains("ZENITH"));

            if (File.Exists(path))
                File.Delete(path);
        }

        [TestMethod]
        public void SpecialCharactersTest()
        {
            string path = @"C:\Test\SpecialChars.txt";

   
            string[] testData = {
                "This is (crazy) test!",
                "Fuzzy-buzzy words...",
                "Zoom: 100%"
            };

            File.WriteAllLines(path, testData);

            DataService ds = new DataService();
            string result = ds.CollectTextFromFile(path);

            Assert.IsTrue(result.Contains("crazy"));
            Assert.IsTrue(result.Contains("Fuzzy"));
            Assert.IsTrue(result.Contains("buzzy"));

            Assert.IsFalse(result.Contains("Zoom"));

            if (File.Exists(path))
                File.Delete(path);
        }
    }
}