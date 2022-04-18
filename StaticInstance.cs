using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Concepts
{
    public class StaticInstanceDemo
    {
        /// <summary>
        /// STATIC METHOD
        /// </summary>
        public static void StaticDemo1()
        {
            Console.WriteLine("I am a Static Method1");
        }
        /// <summary>
        /// INSTANCE METHOD
        /// </summary>
        public void InstanceDemo1()
        {
            Console.WriteLine("I am an Instance Method1");
        }

    }
    internal class StaticInstance
    {
        public static void Main()
        {
            StaticInstance instance = new StaticInstance();
            //static method inside the class
            StaticDemo();
            instance.InstanceDemo();
            //static method outside the class
            StaticInstanceDemo.StaticDemo1();
            StaticInstanceDemo staticInstanceDemo = new StaticInstanceDemo();
            staticInstanceDemo.InstanceDemo1();

        }
        /// <summary>
        /// STATIC METHOD
        /// </summary>
        public static void StaticDemo()
        {
            Console.WriteLine("I am a Static Method");
        }
        /// <summary>
        /// INSTANCE METHOD
        /// </summary>
        public void InstanceDemo()
        {
            Console.WriteLine("I am an Instance Method");
        }
    }
}
