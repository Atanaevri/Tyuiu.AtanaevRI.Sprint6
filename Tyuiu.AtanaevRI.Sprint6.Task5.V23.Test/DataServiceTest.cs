using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.AtanaevRI.Sprint6.Task5.V23.Lib;
using System.IO;

namespace Tyuiu.AtanaevRI.Sprint6.Task5.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadFromDataFile()
        {
            string path = @"C:\Test\InPutFileTask5V23_Test.txt";

            
            string[] testData = {
                "3.1415",
                "-2.718",
                "0",
                "-1.5",
                "2.0",
                "-0.75"
            };

            File.WriteAllLines(path, testData);

            DataService ds = new DataService();
            double[] result = ds.LoadFromDataFile(path);

            Assert.AreEqual(6, result.Length);
            Assert.AreEqual(3.142, result[0]);  
            Assert.AreEqual(-2.718, result[1]); 
            Assert.AreEqual(0, result[2]);       
            Assert.AreEqual(-1.5, result[3]);   
            Assert.AreEqual(2.0, result[4]);   
            Assert.AreEqual(-0.75, result[5]); 

          
            File.Delete(path);
        }

        [TestMethod]
        public void FileNotFoundTest()
        {
            DataService ds = new DataService();

            Assert.ThrowsException<FileNotFoundException>(() =>
                ds.LoadFromDataFile(@"C:\Nonexistent\file.txt"));
        }

        [TestMethod]
        public void EmptyFileTest()
        {
            string path = @"C:\Test\EmptyFile.txt";
            File.WriteAllText(path, "");

            DataService ds = new DataService();
            double[] result = ds.LoadFromDataFile(path);

            Assert.AreEqual(0, result.Length);

            File.Delete(path);
        }

        [TestMethod]
        public void InvalidDataTest()
        {
            string path = @"C:\Test\InvalidData.txt";
            string[] testData = {
                "abc",
                "123",
                "45.6.7",
                "-12.34"
            };

            File.WriteAllLines(path, testData);

            DataService ds = new DataService();
            double[] result = ds.LoadFromDataFile(path);

            Assert.AreEqual(4, result.Length);
            Assert.AreEqual(0, result[0]);    
            Assert.AreEqual(123, result[1]);  
            Assert.AreEqual(0, result[2]);    
            Assert.AreEqual(-12.34, result[3]); 

            File.Delete(path);
        }
    }
}