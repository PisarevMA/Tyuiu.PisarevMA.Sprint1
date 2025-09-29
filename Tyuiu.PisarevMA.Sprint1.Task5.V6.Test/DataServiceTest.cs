using Tyuiu.PisarevMA.Sprint1.Task5.V6.Lib;
namespace Tyuiu.PisarevMA.Sprint1.Task5.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            int k = 20;

            DataService ds = new DataService();
            double res = ds.Calculate(k);

            int result = Convert.ToInt32(res);

            int wait = 6;
            Assert.AreEqual(wait, result);
        }
    }
}
