using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Concepts
{
    /// <summary>
    /// INTERFACE-keyword interface-group of abstract methods and properties,no variables
    /// INTERFACE-SECURITY
    /// INTERFACE-MULTIPLE INTERFACES
    /// </summary>
    public interface IInterfaceOne
    {
        void Display();
    }
    public interface IInterfaceTwo
    {
        void Display();
    }
    /// <summary>
    /// Sample is implementing IInterfaceOne, IInterfaceTwo
    /// </summary>
    public class Sample:IInterfaceOne, IInterfaceTwo
    {
        void IInterfaceOne.Display()
        {
            Console.WriteLine("Interface One");
        }
        void IInterfaceTwo.Display()
        {
            Console.WriteLine("Interface Two");
        }
    }

    internal class Interface
    {
        /// <summary>
        /// Base to Derived
        /// </summary>
        public static void Main()
        {
            IInterfaceOne interfaceone = new Sample();
            interfaceone.Display();
            IInterfaceTwo interfaceTwo = new Sample();
            interfaceTwo.Display();
        }
      

    }
}
