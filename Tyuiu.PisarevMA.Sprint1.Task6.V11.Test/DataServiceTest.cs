using Tyuiu.PisarevMA.Sprint1.Task6.V11.Lib;
namespace Tyuiu.PisarevMA.Sprint1.Task6.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            DataService ds = new DataService();
            string value = "afffcav";
            bool res = ds.CheckeFirstLetterRepetition(value);
            Assert.IsTrue(res);
        }
    }
}
