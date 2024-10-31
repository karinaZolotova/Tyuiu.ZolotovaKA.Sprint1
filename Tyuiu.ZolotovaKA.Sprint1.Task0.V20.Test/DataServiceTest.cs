using Tyuiu.ZolotovaKA.Sprint1.Task0.V20.Lib;
namespace Tyuiu.ZolotovaKA.Sprint1.Task0.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            var res = ds.Calculate();
            Assert.AreEqual(13, res);
        }
    }
}