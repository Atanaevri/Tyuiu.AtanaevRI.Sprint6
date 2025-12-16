using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.AtanaevRI.Sprint6.Task4.V4.Lib
{
    public class DataService : ISprint6Task4V4
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {

            
                int len = stopValue - startValue + 1;
                double[] valueArray = new double[len];

                for (int i = 0; i < len; i++)
                {
                    double x = startValue + i;
                    double denominator = Math.Cos(x) + x;

               
                    if (Math.Abs(denominator) < 0.0001)
                    {
                        valueArray[i] = 0;
                    }
                    else
                    {
                        double numerator = 2 * x + 6;
                        valueArray[i] = Math.Round(numerator / denominator - 3, 2);
                    }
                }

                return valueArray;
            }

            public void SaveToFileText(double[] valueArray, string path)
            {
                using (StreamWriter writer = new StreamWriter(path))
                {
                    foreach (double value in valueArray)
                    {
                        writer.WriteLine(value.ToString("F2"));
                    }
                }
            }
        }
    }
