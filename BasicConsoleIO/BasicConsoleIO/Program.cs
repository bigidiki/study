using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicConsoleIO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Basic Console I/O *****");
            GetUserData();
            Console.ReadLine();
        }
        private static void GetUserData()
        {
            Console.WriteLine("Please enter your name");
            string Username = Console.ReadLine();
            Console.WriteLine("Please enter your age");
            string userage = Console.ReadLine();

            ConsoleColor prevcolor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("Username {0} Your age {1}",Username, userage);
            Console.ForegroundColor = prevcolor;
        }
    }
}
