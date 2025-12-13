
using Tyuiu.AtanaevRI.Sprint6.Task7.V4.Lib;

namespace Tyuiu.AtanaevRI.Sprint6.Task7.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckMatrixTransformation()
        {
            string testFilePath = "test_matrix.csv";

            string[] testData =
            {
                "1;2;3",
                "4;5;8",    
                "7;8;9"
            };

            
            File.WriteAllLines(testFilePath, testData);

            try
            {
                
                DataService ds = new DataService();

             
                int[,] resultMatrix = ds.GetMatrix(testFilePath);

             
          
                Assert.AreEqual(4, resultMatrix[1, 0]); 
                Assert.AreEqual(5, resultMatrix[1, 1]);  
                Assert.AreEqual(4, resultMatrix[1, 2]);  

            
                
            }
            finally
            {
             
                if (File.Exists(testFilePath))
                {
                    File.Delete(testFilePath);
                }
            }
        }
    }
}