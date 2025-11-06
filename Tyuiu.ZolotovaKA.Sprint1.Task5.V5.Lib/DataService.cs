using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.ZolotovaKA.Sprint1.Task5.V5.Lib
{
    public class DataService : ISprint1Task5V5
    {
        public int Calculate(double x)
        {
            double d = (x % 1) * 10-1;
            var res = Convert.ToInt32(d);
            return res;
        }
    }
}