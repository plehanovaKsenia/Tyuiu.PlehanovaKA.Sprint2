using Tyuiu.PlehanovaKA.Sprint2.Task5.V12.Lib;
namespace Tyuiu.PlehanovaKA.Sprint2.Task5.V12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();


            Console.Title = "Спринт #2 | Выполнила: Плеханова К. А. | СМАРТб-26-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Оператор switch                                                   *");
            Console.WriteLine("* Задание#5                                                               *");
            Console.WriteLine("* Вариант#12                                                              *");
            Console.WriteLine("* Выполнила: Плеханова Ксения Анатольевна | СМАРТб-26-1                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дата некоторого дня характеризуется тремя натуральными числами: год,    *");
            Console.WriteLine("* порядковый номер месяца и число. Определить дату предыдущего дня.       *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            int g, m, n;
            Console.WriteLine("* Введите число                                                           *");
            g = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("* Введите месяц                                                           *");
            m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("* Введите год                                                             *");
            n = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            var res = ds.FindDateOfPreviousDay(g,m,n);
            Console.WriteLine("Вчерашняя дата: " + res);
        }
    }
}
