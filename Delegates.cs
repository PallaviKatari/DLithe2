using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Concepts
{
    /// <summary>
    /// Delegate->reference type variable->reference of the method->Runtime
    /// Delegate-Class-System
    /// </summary>
    /// //STEP 1-CREATING A DELEGATE
    /// SINGLE-CAST DELEGATE
    public delegate void CalculatorDelegate(int a, int b);
    // MULTI-CAST DELEGATE 
    public delegate void CalculatorDelegate1(int a, int b);

    public class Delegates
    {
        
        /// <summary>
        /// Calculate Sum
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        public void Add(int a,int b)
        {
            Console.WriteLine("Sum is:{0}", a + b);
        }
        /// <summary>
        /// Calculate Difference
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        public void Sub(int a, int b)
        {
            Console.WriteLine("Difference is:{0}", a - b);
        }
        /// <summary>
        /// Calculate Product
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        public void Mul(int a, int b)
        {
            Console.WriteLine("Product is:{0}", a * b);
        }
    }
    public class DelegatesDemo
    {
        public static void Main()
        {
            //Instance for the class
            Delegates delegates = new Delegates();
            //instance for the delegate
            //Single-cast delegate
            CalculatorDelegate calc = delegates.Add; //reference of the Add method 
            calc(10, 10);
            calc=delegates.Sub;
            calc(20, 10); //or calc.Invoke(10, 20);
            //Multi-cast delegate
            CalculatorDelegate1 calc1 = delegates.Add;
            calc1 += delegates.Sub;
            calc1 += delegates.Mul;
            calc1(100,100);
            calc1 -= delegates.Sub;
            calc1(5,5);

        }
    }
}
