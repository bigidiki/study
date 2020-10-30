using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiRinat
{
    class Program
    {
        static void Main(string[] args)
        {
            Mya(456,456);
            Console.ReadLine();
        }
        public static void hifather()
        {
            ConsoleColor cve2 = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Rinat");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(" Hi");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(" How are u?");
            Console.ForegroundColor = cve2;
        }
        public static void myfreindmoron()
        {
            ConsoleColor cve = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(" My");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(" Freind");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write(" Moron");
            Console.ForegroundColor = cve;
        }
        public static void UseDatesandTimes()
        {
            Console.WriteLine("=> Dates and Times:");
            DateTime dt = new DateTime(2020,10,29);
            Console.WriteLine("The day of {0} is {1}",dt.Date,dt.DayOfYear);
            dt = dt.AddMonths(2);
            Console.WriteLine("Daylight savings: {0}", dt.IsDaylightSavingTime());
            TimeSpan ts = new TimeSpan(16, 40, 0);
            Console.WriteLine(ts);
            Console.WriteLine(ts.Subtract(new TimeSpan (0,15,0)));
        }
        public static void Mya(int x,int z)
        {

            Console.WriteLine("{0} {1}",x,z);
        }
    }
}
