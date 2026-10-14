using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.PlehanovaKA.Sprint2.Task7.V3.Lib
{
    public class DataService : ISprint2Task7V3
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            if ((y <= 1 - Math.Pow(x, 2)) && (Math.Pow(x, 2) + Math.Pow(y - 1, 2) <= 1)) return true;
            return false;
        }
    }
}
