using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.BayazitovEA.Sprint6.Task0.V6.Lib
{
    public class DataService : ISprint6Task0V6
    {
        public double Calculate(int x)
        {
            double res = (double)x/(Math.Sqrt((double)x * (double)x + (double)x));
            return Math.Round(res,3);
        }
    }
}
