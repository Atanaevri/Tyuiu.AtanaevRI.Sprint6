using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.AtanaevRI.Sprint6.Task4.V4.Lib
{
    public class DataService : ISprint6Task4V4
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
          
                int length = Math.Abs(stopValue - startValue) + 1;
                double[] resultArray = new double[length];

                int index = 0;
                for (int x = startValue; x <= stopValue; x++)
                {
                    double denominator = Math.Cos(x) + x;

                    if (Math.Abs(denominator) < 0.0001)
                    {
                        resultArray[index] = 0;
                    }
                    else
                    {
                        double value = (2 * x + 6) / denominator - 3;
                        resultArray[index] = Math.Round(value, 2);
                    }

                    index++;
                }

                return resultArray;
            }

           
            public string GetResultString(int startValue, int stopValue)
            {
                double[] values = GetMassFunction(startValue, stopValue);
                string result = "Таблица значений функции:\n";
                result += "x\t\tF(x)\n";
                result += "-----------------------\n";

                for (int i = 0; i < values.Length; i++)
                {
                    int x = startValue + i;
                    result += $"{x}\t\t{values[i]}\n";
                }

                return result;
            }

            public bool SaveToFile(string path, int startValue, int stopValue)
            {
                try
                {
                    double[] values = GetMassFunction(startValue, stopValue);

                    using (StreamWriter writer = new StreamWriter(path))
                    {
                        writer.WriteLine("Результаты табулирования функции F(x) = (2x + 6) / (cos(x) + x) - 3");
                        writer.WriteLine($"Диапазон: [{startValue}; {stopValue}]");
                        writer.WriteLine();
                        writer.WriteLine("x\t\tF(x)");
                        writer.WriteLine("-----------------------");

                        for (int i = 0; i < values.Length; i++)
                        {
                            int x = startValue + i;
                            writer.WriteLine($"{x}\t\t{values[i]}");
                        }

                        writer.WriteLine();
                        writer.WriteLine($"Всего точек: {values.Length}");
                    }

                    return true;
                }
                catch
                {
                    return false;
                }
            }

           
            public Tuple<double[], double[]> GetGraphPoints(int startValue, int stopValue)
            {
                double[] xValues = new double[Math.Abs(stopValue - startValue) + 1];
                double[] yValues = GetMassFunction(startValue, stopValue);

                for (int i = 0; i < xValues.Length; i++)
                {
                    xValues[i] = startValue + i;
                }

                return Tuple.Create(xValues, yValues);
            }
        }
    }
}
    

