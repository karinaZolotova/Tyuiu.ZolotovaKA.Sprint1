using Tyuiu.ZolotovaKA.Sprint1.Task2.V4.Lib;
namespace Tyuiu.ZolotovaKA.Sprint1.Task2.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 2;
            var res = ds.CalculateSquare(x);
            Assert.AreEqual(4, res);
        }
    }
}