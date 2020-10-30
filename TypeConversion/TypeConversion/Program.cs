using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
           
            ProccesBytes();

        }
        #region add
        static int Add(int x, int y)
        {
            return x + y;
        }
        #endregion
        #region justadd
        static void JustAdd(short x, short y)
        {
            Console.WriteLine(" Fun with type conversions ");
            int numb1 = x, numb2 = y;
            Console.WriteLine("{0} + {1} = {2}", numb1, numb2, Add(numb1, numb2));
            Console.ReadLine();
        }
        #endregion

        #region probytes
        static void ProccesBytes()
        {
            byte b1 = 250;
            byte b2 = 100;
           
                byte sum = (byte)Add(b1, b2);
                Console.WriteLine("sum = {0}", sum);
            
            Console.ReadLine();
        }
        #endregion
    }
}
