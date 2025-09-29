using Tyuiu.PisarevMA.Sprint1.Task4.V28.Lib;
namespace Tyuiu.PisarevMA.Sprint1.Task4.V28.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TCalcTest()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 1;
            double res = 0.007;
            Assert.AreEqual(res, ds.Calculate(x, y));
        }
    }
}
