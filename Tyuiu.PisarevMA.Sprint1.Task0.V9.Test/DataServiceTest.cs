using Tyuiu.PisarevMA.Sprint1.Task0.V9.Lib;
namespace Tyuiu.PisarevMA.Sprint1.Task0.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.Calculate();
            Assert.AreEqual(3, res);
        }
    }
}