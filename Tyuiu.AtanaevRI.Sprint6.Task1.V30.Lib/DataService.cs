using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.AtanaevRI.Sprint6.Task1.V30.Lib
{
    public class DataService : ISprint6Task1V30
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
           
                int length = Math.Abs(stopValue - startValue) + 1;
                double[] result = new double[length];

                for (int i = 0, x = startValue; x <= stopValue; x++, i++)
                {
                    
                    double denominator = Math.Cos(x) - 2 * x;

                    if (denominator == 0)
                    {
                        result[i] = 0;
                    }
                    else
                    {
                        
                        double value = (2 * x - 3) / denominator + 5 * x - 6;
                        result[i] = Math.Round(value, 2);
                    }
                }

                return result;
            }
        }
    }


    

