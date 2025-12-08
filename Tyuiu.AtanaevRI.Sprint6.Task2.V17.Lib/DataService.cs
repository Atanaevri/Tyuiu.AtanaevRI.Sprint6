using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.AtanaevRI.Sprint6.Task2.V17.Lib
{
    public class DataService : ISprint6Task2V17
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = stopValue - startValue + 1;
            double[] result = new double[len];

            for (int i = 0; i < len; i++)
            {
                int x = startValue + i;

              
                double value;
                try
                {
                    value = Math.Cos(x) + (4 * x) / 2.0 - Math.Sin(x) * 3 * x;
                }
                catch (DivideByZeroException)
                {
                    value = 0;
                }

                result[i] = value;
            }

            return result;
        }
    }
}
   
