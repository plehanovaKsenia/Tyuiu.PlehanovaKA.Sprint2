using Tyuiu.PlehanovaKA.Sprint2.Task5.V12.Lib;
namespace Tyuiu.PlehanovaKA.Sprint2.Task5.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDateOfPreviousDay()
        {
            DataService ds = new DataService();
            int g = 2026;
            int m = 1;
            int n = 1;
            string wait = "31.12.2025";
            var res = ds.FindDateOfPreviousDay(g, m, n);
            Assert.AreEqual(wait, res);
        }
    }
}
