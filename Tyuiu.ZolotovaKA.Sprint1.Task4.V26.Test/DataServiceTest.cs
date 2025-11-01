using Tyuiu.ZolotovaKA.Sprint1.Task4.V26.Lib;
namespace Tyuiu.ZolotovaKA.Sprint1.Task4.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 2;
            double wait = 0.057;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}