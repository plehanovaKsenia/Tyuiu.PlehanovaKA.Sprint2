using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.PlehanovaKA.Sprint2.Task2.V21.Lib
{
    public class DataService : ISprint2Task2V21
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            if ((3<=y && y<=4)&&(x==3 || 9<=x && x<=12)) return true;
            if ((y==5) && (x == 3 || 6 <= x && x <= 12)) return true;
            if ((6 <= y && y <= 7) && ( 3 <= x && x <= 13)) return true;
            if ((8 <= y && y <= 9) && (4 <= x && x <= 6 || 10 <= x && x <= 12)) return true;
            if ((y==10) && ( 10 <= x && x <= 12)) return true;
            if ((y == 11) && (9 <= x && x <= 12)) return true;
            if ((y == 12) && (9 <= x && x <= 10)) return true;

            return false;
        }
    }
}
