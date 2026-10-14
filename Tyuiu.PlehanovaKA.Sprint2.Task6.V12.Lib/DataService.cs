using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.PlehanovaKA.Sprint2.Task6.V12.Lib
{
    public class DataService : ISprint2Task6V12
    {
        public string FindDateOfPreviousDay(int g, int m, int n)
        {
            int yg, ym, yn;

            switch (n)
            {
                case 1:

                    (yg, ym, yn) = m switch
                    {
                        1 => (g - 1, 12, 31),
                        2 or 4 or 6 or 9 or 11 => (g, m - 1, 31),
                        3 => (g, m - 1, 29),
                        _ => (g, m - 1, 30)
                    };
                    break;

                default:
                    yg = g; ym = m; yn = n - 1;
                    break;
            }
            string ygs = Convert.ToString(yg);
            string yms = Convert.ToString(ym);
            string yns = Convert.ToString(yn);
            yms = yms.Length == 2 ? yms : '0' + yms;
            yns = yns.Length == 2 ? yns : '0' + yns;
            return (yns + '.' + yms + '.' + ygs);
        }
    }
}
