using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithStrings
{
    class Program
    {
        static void Main(string[] args)
        {
           
           
            SESpecifying();
            Console.ReadLine();
        }
        static void BasicStringsFunctionality()
        {
            Console.WriteLine("=> Basic strings functionality:");
            string firstname = "Freddy";
            Console.WriteLine("Value of firstname: {0}",firstname);
            Console.WriteLine("firstname has {0} characters",firstname.Length);
            Console.WriteLine("firstname in uppercase: {0}",firstname.ToUpper());
            Console.WriteLine("firstname in lowercase: {0}",firstname.ToLower());
            Console.WriteLine("firstname contains the letter y?: {0}",firstname.Contains("y"));
            Console.WriteLine();
        }
        static void StringConcat()
        {
            Console.WriteLine("String Concat:");
            string s1 = "Programming the \t";
            string s2 = "PsycholDrill";
            string s3 = String.Concat(s1, s2);
            string s4 = s1 + s2;
            Console.WriteLine(s3);
            Console.WriteLine(s4);
        }
        public static void Characters()
        {
            string mylong = @"Very
Very
Very";
            Console.WriteLine(mylong);
        }
        public static void StringEquelity()
        {
            Console.WriteLine("String equelity:");
            string s1 = "Hello!";
            string s2 = "Yo";
            Console.WriteLine("s1=={0}",s1);
            Console.WriteLine("s2=={0}",s2);
            Console.WriteLine();

            Console.WriteLine("s1 == s2 {0}",s1==s2);
            Console.WriteLine("s1 == Hello!{0}",s1=="Hello!");
            Console.WriteLine("s1 == HELLO!{0}",s1=="HELLO!");
            Console.WriteLine("s1 == hello!{0}",s1=="hello!");
            Console.WriteLine("s1.Equels(s2): {0}",s1.Equals(s2));
            Console.WriteLine("Yo.Equels(s2): {0}","Yo".Equals(s2));

            string s3 = "hElLo!";
            if (s1.ToUpper() == s3.ToUpper()) {
                Console.WriteLine("{0} = {1}",s1.ToUpper(),s3.ToUpper());
            }           
        }
        public static void SESpecifying()
        {
            Console.WriteLine("=> String equality:");
            string s1 = "Hello!";
            string s2 = "HELLO!";
            Console.WriteLine("s1 = {0}", s1);
            Console.WriteLine("s2 = {0}", s2);
            Console.WriteLine();
            Console.WriteLine("Default rules: s1 = {0},s2 ={1}s1.Equels(2): {2}",s1,s2,s1.Equals(s2));
            Console.WriteLine("Ignore case: s1.Equels(s2,StringComparsion.OrdinalIgnoreCase): {0}",s1.Equals(s2,StringComparison.OrdinalIgnoreCase));
            Console.WriteLine("IgnoreCase,InvariantCultur: " +
                "s1.Equals(s2,StringComparison.InvariantCultureIgnoreCase): {0}",
            s1.Equals(s2,StringComparison.InvariantCultureIgnoreCase));
            Console.WriteLine();
            Console.WriteLine("Default rules: s1={0},s2={1} s1.IndexOf(\"E\"): {2}",s1,s2,s1.IndexOf("E"));
            Console.WriteLine("Ignore case: s1.IndexOf(\"E\",StringComprasion.OrdinalIgnoreCase: {0})", s1.IndexOf("E",StringComparison.OrdinalIgnoreCase));
            Console.WriteLine("Ignore case,Invariant Culture: s1.IndexOf(\"E\",StringComprasion.OrdinalIgnoreCase: {0})", s1.IndexOf("E", StringComparison.InvariantCultureIgnoreCase));
        }
    }
}
