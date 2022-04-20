using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Concepts
{
    internal class Overloading
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static int Area(int a)
        {
            return a * a;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static int Area(int a,int b)
        {
            return a * b;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public static int Area(int a,int b,int c)
        {
            return a * b * c;
        }
        /// <summary>
        /// Method Overloading
        /// </summary>
        public static void Main()
        {
            int square=Area(2);
            Console.WriteLine("Area of a Square:{0}",square);
            int rect = Area(2,3);
            Console.WriteLine("Area of a Rectangle:{0}", rect);
            int cube = Area(2,3,4);
            Console.WriteLine("Area of a Cube:{0}", cube);
        }
    }
}
