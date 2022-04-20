using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Concepts
{
    /// <summary>
    /// ABSTRACTION-ABSTRACT CLASSES AND INTERFACES
    /// ABSTRACT CLASS-abstract keyword,abstract methods(method with no definition),non-abstract method,
    ///                cannot create an instance for the abstract class(inherited),
    ///                all the abstract methods must be overriden in the derived class
    /// </summary>
    /// Method Overriding
        //Abstract Class
        //Inheritance(Hierarc)
        //protected
        //Base to Derived instance
    //public abstract class Abstraction
    //{
    //    public abstract void add();
    //    public void sum()
    //    {

    //    }
    //}
    //public class Sample:Abstraction
    //{
    //    public override void add()
    //    {

    //    }

    //}
    //internal class Demo
    //{
    //    public static void Main()
    //    {
    //        //Abstraction a=new Abstraction(); //error
    //        Sample sample = new Sample();

    //    }
    //}


    public abstract class Bonus_Calculation
    {
        protected double salary;
        /// <summary>
        /// ABSTRACT METHOD-NO IMPLEMENTATION
        /// </summary>
        public abstract void GetSalary();

        /// <summary>
        /// NON ABSTRACT METHOD
        /// </summary>
        /// <param name="bonus"></param>
        public void Calculate_Bonus(double bonus)
        {
            Console.WriteLine("Year end Bonus:{0}", salary + bonus);
        }
    }
    /// <summary>
    /// INHERITING ABSTRACT CLASS
    /// </summary>
    public class Junior:Bonus_Calculation
    {
        /// <summary>
        /// OVERRIDE ABSTRACT METHOD
        /// </summary>
        public override void GetSalary()
        {
            salary = 35000;
        }

    }
    /// <summary>
    /// INHERITING ABSTRACT CLASS
    /// </summary>
    public class Senior : Bonus_Calculation
    {
        /// <summary>
        /// OVERRIDE ABSTRACT METHOD
        /// </summary>
        public override void GetSalary()
        {
            salary = 55000;
        }

    }
    /// <summary>
    /// Accessing the Abstract Class
    /// </summary>
    public class Abstraction
    {
        public static void Main()
        {
            //Base to Derived instance
            Bonus_Calculation calc;
            calc=new Junior();
            calc.GetSalary();
            calc.Calculate_Bonus(15000);
            calc = new Senior();
            calc.GetSalary();
            calc.Calculate_Bonus(25000);

        }
    }
}
