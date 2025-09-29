using Tyuiu.PisarevMA.Sprint1.Task6.V11.Lib;
namespace Tyuiu.PisarevMA.Sprint1.Task6.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpressionTrue()
        {
            DataService ds = new DataService();
            string value = "áàðàáàí";
            var res = ds.CheckeFirstLetterRepetition(value);
            Assert.AreEqual(true, res);
        }
        [TestMethod]
        public void ValidExpressionFalse()
        {
            DataService ds = new DataService();
            string value = "àðáóç";
            var res = ds.CheckeFirstLetterRepetition(value);
            Assert.AreEqual(false, res);

        }
    }
}
