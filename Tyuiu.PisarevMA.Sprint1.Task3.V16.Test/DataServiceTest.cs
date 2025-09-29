using Tyuiu.PisarevMA.Sprint1.Task3.V16.Lib;
namespace Tyuiu.PisarevMA.Sprint1.Task3.V16.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckCoeffOfQuadraticEquation()
        {
            DataService ds = new DataService();
            double quadraNum1 = 1.0006;
            double quadraNum2 = 2.0000;
            double quadraWait = -3.001;
            Assert.AreEqual(quadraWait, ds.CoeffOfQuadraticEquation(quadraNum1, quadraNum2));
        }
    }
}
