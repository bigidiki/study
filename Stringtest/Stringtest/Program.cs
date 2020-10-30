using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stringtest
{
    class Program
    {
        static void Main(string[] args)
        {
            string st = string.Format("{2} {1} {0}", 1, 2, 3);
            CharFunctionality();
            Console.WriteLine(st);
            ParseFromStrings();
            Console.ReadLine();
        }
        static void ParsewithTryParse()
        {
            Console.WriteLine("=> Data type parsing with tryparsing:");
            if (bool.TryParse("True",out bool b) ) {
                Console.WriteLine("Value of b: {0}",b);
            }
            string value = "Hello";
            if(double.TryParse(value, out double d))
            {
                Console.WriteLine("Value of d: {0}", d);
            }
            else
            {
                Console.WriteLine("Failed to convert the iput ({}) to a double", value);
                Console.WriteLine();
            }
        }
        public static void ParseFromStrings()
        {
            bool b9 = bool.Parse("True");
            Console.WriteLine("Value of b: {0}", b9);
            int i = int.Parse("8");
            Console.WriteLine("Value of i: {0}", i);
        }
        public static void CharFunctionality()
        {
            Console.WriteLine("Char Functionality:");
            char mychar = 'a';
            Console.WriteLine("char is Digit('a'): {0}",char.IsDigit(mychar));
            Console.WriteLine("char is Letter('a'): {0}",char.IsLetter(mychar));
            Console.WriteLine("char is Whitespace('Hello There, 5'): {0}",char.IsWhiteSpace("Hello There",5));
            Console.WriteLine("char is Punctuation('?'): {0}",char.IsPunctuation('?'));
            Console.WriteLine(" ");
        }
        public static void DefaultDeclaretions()
        {
            Console.WriteLine("=> Default Declaretions:");
            int myint = default;
            bool b5 = default;
            float f1 = default;
            double d1 = default;
            decimal d2 = default;
            long l1 = default;
            Console.WriteLine(myint+" "+b5+" "+f1+" "+d1+" "+d2+" "+l1 );
        }
        public static void LocalVarDeclaration()
        {
            bool b1 = false, b2 = true, b3 = b1;
            System.Boolean b4 = false;
            Console.WriteLine("{0},{1},{2},{3}",b1,b2,b3,b4);
        }
        public static void FormatNumericalData()
        {
            Console.WriteLine("The value 99999 in variuos formats:");
            Console.WriteLine("C format: {0:C}",99999);
            Console.WriteLine("d9 format: {0:d9}",99999);
            Console.WriteLine("f3 format: {0:f3}",99999);
            Console.WriteLine("n format: {0:n}",99999);
            Console.WriteLine("E format: {0:E}",99999);
            Console.WriteLine("e format: {0:e}",99999);
            Console.WriteLine("X format: {0:X}",99999);
            Console.WriteLine("x format: {0:x}",99999);
        }
    }
}
