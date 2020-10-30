using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simplecsharpapp
{
    class Program
    {
        static int Main(string[] args)
        {
            int a, b,c;
            int.TryParse(args[0],out a);
            int.TryParse(args[1], out b);
            c = a + b;
            Console.WriteLine(c);
            Console.WriteLine(System.Environment.OSVersion);
            foreach(var n in System.Environment.GetLogicalDrives())
            Console.WriteLine(n);
            Console.ReadLine();
            return 0;
        }
    }
}
