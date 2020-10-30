using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contactiation
{
    class Program
    {
        static void Main(string[] args)
        {
            StaticInter();
            Console.ReadLine();
        }

        #region stringcont
        public static void StringContation()
        {
            string s1 = "Lalala";
            string s2 = " Bomb";
            string s3 = s1 + s2;
            Console.WriteLine(s3);
        }
        #endregion

        #region funstring 
        public static void FunString()
        {
            Console.WriteLine("=> StringBuldier");
            StringBuilder sb = new StringBuilder("Fantastic Games");
            sb.Append("\n");
            sb.AppendLine("Bigi Diki");
            sb.AppendLine("Bi Di");
            sb.AppendLine("Deus aw" + "2");
            sb.AppendLine("System Shok");
            Console.WriteLine(sb.ToString());
         
            sb.Replace("2"," Invasibale war");
            Console.WriteLine("sb has {0} chars", sb.Length);
            Console.WriteLine(sb.ToString());
            Console.WriteLine();
        }
        #endregion

        #region staticinter
        public static void StaticInter()
        {
            int age = 4;
            string name = "Soren";
            string greet = $"Hello {name} your age {age}";
            Console.WriteLine(greet);
        }
        #endregion
    }
}
