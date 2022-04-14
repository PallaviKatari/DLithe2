using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Concepts
{
    /// <summary>
    /// CONSTRUCTORS-SPECIAL METHOD
    /// Same name as the class name
    /// Automatically invoked
    /// no return type
    /// Constructor Overloading
    /// OVERLOADING-RULES-NO OF PARAMETERS/SEQUENCE OF PARAMETERS/DATATYPE
    /// </summary>
    public class Constructors
    {
        public int empid;
        public string empname;
        /// <summary>
        /// Default Constructor
        /// </summary>
        public Constructors()
        {
            empid = 1;
            empname = "John";

        }
        /// <summary>
        /// Instance Method to display the employee details
        /// </summary>
        public void Display()
        {
            Console.WriteLine("Employee id is:{0}",empid);
            Console.WriteLine("Employee Name is:{0}", empname);
        }
        /// <summary>
        /// Constructor with 2 parameters
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        public Constructors(int a,int b) //10,20
        {
            Console.WriteLine("Sum is:{0}", a + b);//10+20=30
        }
        public Constructors(int id,string name)
        {
            Console.WriteLine($"ID is {id} and Name is {name}");
        }
        public Constructors(string name, int id)
        {
            Console.WriteLine($"ID is {id} and Name is {name}");
        }
        public static void Main()
        {
            //automatically the default constructor is invoked
            Constructors c = new Constructors();
            //automatically invokes the constructor with 2 integer parameters
            Constructors c1 = new Constructors(10,20);
            //automatically invokes the constructor with (int,string) format
            Constructors c2 = new Constructors(10, "Jancy");
            //automatically invokes the constructor with (string,int) format
            Constructors c3 = new Constructors("Nancy", 100);
            //invoking the instance method
            c.Display();


        }



}
}
