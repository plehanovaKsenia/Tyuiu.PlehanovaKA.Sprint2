using Tyuiu.PlehanovaKA.Sprint2.Task4.V26.Lib;
namespace Tyuiu.PlehanovaKA.Sprint2.Task4.V26.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckValidCalculate()
        {
            DataService ds = new DataService();
            double x = 3;
            double y = 1;
            double wait = 8;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
