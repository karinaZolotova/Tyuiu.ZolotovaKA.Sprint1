using Tyuiu.ZolotovaKA.Sprint1.Task6.V13.Lib;
namespace Tyuiu.ZolotovaKA.Sprint1.Task6.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            string str = "ABCD";
            Assert.AreEqual(true, ds.CheckWordsAlphabet(str));
        }
    }
}