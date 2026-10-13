using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.PlehanovaKA.Sprint2.Task5.V12.Lib
{
    public class DataService : ISprint2Task5V12
    {
        public string FindDateOfPreviousDay(int g, int m, int n)
        {
            int yg, ym, yn;

            switch (n)
            {
                case 1:

                    switch(m)
                    {
                        case 1:
                            yg = g - 1; ym = 12; yn = 31;
                            break;
                        case 2:
                        case 4:
                        case 6:
                        case 9:
                        case 11:
                            yg = g; ym= m - 1; yn = 31;
                            break;
                        case 3:
                            yg = g; ym = m - 1; yn = 29;
                            break;
                        default:
                            yg = g; ym = m - 1; yn = 30;
                            break;
                    }
                    break;
                default:
                    yg = g; ym = m; yn = n - 1;
                    break;
            }
            string ygs = Convert.ToString(yg);
            string yms = Convert.ToString(ym);
            string yns = Convert.ToString(yn);
            return (yns+'.'+yms+'.'+ygs);
        }
    }
}
