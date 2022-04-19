using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Concepts
{
    /// <summary>
    /// STRUCTURE FOR EMPLOYEE DETAILS
    /// STRUCTURE-Small application,does not support inheritance,protected not supported,
    ///             cannot have default constructors,can have parameterized constructors
    /// CLASS-Large application,inheritance(protected),can have default constructors
    /// </summary>
    struct Employee
    {
        public int empid;
        public string empname;
        /// <summary>
        /// Accept Employee details
        /// </summary>
        public void GetDetails()
        {
            Console.WriteLine("Enter the ID and Name");
            empid=Convert.ToInt32(Console.ReadLine());
            empname=Console.ReadLine();
        }
        /// <summary>
        /// Display Emloyee details
        /// </summary>
        public void DisplayDetails()
        {
            Console.WriteLine("Employee ID is:{0}",empid);
            Console.WriteLine("Employee Name is:{0}",empname);
        }
        /// <summary>
        /// Parameterized Constructor in a Structure
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        public Employee(int id,string name)
        {
            empid=id;
            empname=name;
            Console.WriteLine("Employee details are:{0} and {1}", empid, empname);
        }
    }
    internal class Structures
    {
        /// <summary>
        /// Accessing the Employee Structure from Main()
        /// </summary>
        public static void Main()
        {
            Employee emp=new Employee();
            Employee emp2=new Employee(101,"Peter");
            emp.GetDetails();
            emp.DisplayDetails();
        }
    }
}
