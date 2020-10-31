using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplicidyTypedLocalVars
{
    class Program
    {
        static void Main(string[] args)
        {
            DeclareImplicitVar();
            Console.ReadKey();
        }
        static void DeclareImplicitVar()
        {
            int MyInt = 0;
            bool Mybool = true;
            string MyString = "Time, marches on...";

            var myInt2 = 0;
            var MyBool2 = true;
            var MyString2 = "Time, marches on...";


            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("my myInt is a: {0}", MyInt.GetType().Name);
            Console.WriteLine("my myBool is a: {0}", Mybool.GetType().Name);
            Console.WriteLine("my myString is a: {0}", MyString.GetType().Name);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("my myInt is a: {0}",myInt2.GetType().Name);
            Console.WriteLine("my myBool is a: {0}",MyBool2.GetType().Name);
            Console.WriteLine("my myString is a: {0}",MyString2.GetType().Name);
        }
    }
}
