using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Concepts
{
    /// <summary>
    /// Value Type-int,char,float,double,bool - cannot accept the NULL value
    /// C# 2.0- NULLABLES-Value Type- can accept the NULL value
    /// </summary>
    internal class Nullables
    {
        public static void Main()
        {
            int num1 = 10;
            //SYNTAX FOR NULLABLE
            int? num2 = null;
            //NULLABLE GENERIC 
            Nullable<int> num3=null;
            Console.WriteLine("Num1 is:{0}", num1);
            Console.WriteLine("Null Values are:{0} and {1}", num2, num3);
            //NULL COALESCING OPERATOR ??
            int? a = null;
            int? b = 10;
            int? c;
            c = a ?? b;
            Console.WriteLine("C is:{0}", c);
            c = a ?? 200;
            Console.WriteLine("C is:{0}", c);
        }
    }
}
