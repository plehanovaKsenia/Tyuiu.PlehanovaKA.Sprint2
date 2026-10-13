using Tyuiu.PlehanovaKA.Sprint2.Task3.V24.Lib;
namespace Tyuiu.PlehanovaKA.Sprint2.Task3.V24.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckValidCalculate()
        {
            DataService ds = new DataService();
            double x = 1;
            double wait = 10.988;
            var res = ds.Calculate(x);
            Assert.AreEqual(wait, res);
        }
    }
}
