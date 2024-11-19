using Tyuiu.ZolotovaKA.Sprint1.Task3.V3.Lib;

namespace Tyuiu.ZolotovaKA.Sprint1.Task3.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataServiceTest ds = new DataServiceTest();
            double x = 9;
            double y = 7.5;
            double z = 5;
            double wait = 337.5;
            var res = ds.ParallelepipedVolume(x, y, z);
            Assert.AreEqual(wait, res);
        }
    }
}