using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Concepts
{
    /// <summary>
    /// METHOD OVERRIDING
    /// </summary>
    public class Course1
    {
        public virtual void Message()
        {
            Console.WriteLine("COURSE DETAILS");
        }
    }
    /// <summary>
    /// Derived class inheriting the base with virtual method
    /// </summary>
    public class CSharp : Course1
    {
        /// <summary>
        /// Virtual Method overridden
        /// </summary>
        public override void Message()
        {
            base.Message();
            Console.WriteLine("Csharp Programming");
        }

    }

    internal class VirtualFunctions
    {
        public static void Main()
        {
            CSharp c = new CSharp();
            c.Message();
        }
        

    }
}
