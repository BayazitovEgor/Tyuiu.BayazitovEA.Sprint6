using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.BayazitovEA.Sprint6.Task1.V1.Lib
{
    public class Class1 : ISprint6Task1V1
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = (stopValue - startValue) + 1;
            double[] results;

            results = new double[len];
            double y;
            int count = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                
                y = Math.Round(Math.Cos(2 * x) + (Math.Sin(x) / (x + 2.5)) + 2 * x, 2);
                results[count] = y;
                if (x == 0) { results[count] = 0; }
                count++;
            }

            return results;
        }
    }
}
