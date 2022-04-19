using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Concepts
{
    internal class ParamArrays
    {
        /// <summary>
        /// PARAMS ARRAY
        /// </summary>
        /// <param name="a"></param>
        public static void OrderDetails(params int[] a)
        {
            foreach(int i in a)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("**************************");

        }
        public static void Main()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8 };
            //First Call
            OrderDetails(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12);
            //Second Call
            OrderDetails(1, 2, 3, 4, 5, 6, 7);
            //Third Call
            OrderDetails(numbers);

        }

    }
}
