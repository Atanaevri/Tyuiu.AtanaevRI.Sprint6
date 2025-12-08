using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.AtanaevRI.Sprint6.Task0.V30.Lib
{
    public class DataService : ISprint6Task0V30
    {
        public double Calculate(int x)
        {
            double y = x * Math.Sqrt(x + 3);
            double yRound = Math.Round(y, 3);
            return yRound;
        }
    }
}
