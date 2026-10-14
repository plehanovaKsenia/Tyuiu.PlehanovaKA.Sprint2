using Tyuiu.PlehanovaKA.Sprint2.Task7.V3.Lib;
namespace Tyuiu.PlehanovaKA.Sprint2.Task7.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 1;
            bool wait = false;
            var res = ds.CheckDotInShadedArea(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
