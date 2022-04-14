using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Concepts
{
    /// <summary>
    /// Operators in C#
    /// </summary>
    internal class Operators
    {
        /// <summary>
        /// Operators-Operations/Calculations/Manipulations
        /// Arithmetic,Logical,Relational,Bitwise,Arithmetic Assignment,Increment and Decrement
        /// </summary>
        public static void Main()
        {
            // Arithmetic
            int num1 = 100;
            int num2 = 21;
            int num3;
            num3=num1 + num2;
            Console.WriteLine("Added Value is:{0}",num3);
            num3 = num1 % num2;
            Console.WriteLine("Remainder Value is:{0}", num3);

            //Arithmetic Assignment
            int a = 30;
            int b = 20;
            a -= b;//-=  a=a-b
            Console.WriteLine("Subtracted value is:{0}", a);

            //Increment and Decrement
            //++ and --
            //pre and post
            int i = 10;
            Console.WriteLine("Pre Increment:{0}", ++i);
            Console.WriteLine("Post Increment:{0}", i++);

        }
    }
}
