using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CSharp_Concepts
{
    /// <summary>
    /// INHERITANCE-REUSABILITY
    /// INHERITANCE-4(SINGLE,MULTI-LEVEL,HYBRID,HIERAR)
    /// BASE CLASS
    /// </summary>
    internal class Course
    {
        protected string CourseName;
        protected void Message()
        {
            Console.WriteLine("Welcome to the Training Institution");
        }
       
    }
    /// <summary>
    /// DERIVED CLASS
    /// </summary>
    internal class CourseDetails:Course
    {
        public int CourseId;
        public int CourseFees;
       
        
        /// <summary>
        /// ACCEPT COURSE DETAILS
        /// </summary>
        public void GetDetails()
        {
            CourseId = 100;
            CourseName = "C#";
            CourseFees = 1000;
        }
        /// <summary>
        /// DISPLAY COURSE DETAILS
        /// </summary>
        protected void Display_Details()
        {
            base.Message();           
            Console.WriteLine("CourseId is:{0}", CourseId);
            Console.WriteLine("CourseName is:{0}", CourseName);
            Console.WriteLine("CourseFees is:{0}", CourseFees);
        }
    }
    internal class CourseStructure:CourseDetails
    {
        public int Course_Basic;
        public string Course_BasicPrg;
        public int Course_Advanced;
        public string Course_AdvancedPrg;
        public void Get_CourseStructure()
        {
            Course_Basic = 1001;
            Course_BasicPrg = "C# Basic";
            Course_Advanced = 1002;
            Course_AdvancedPrg = "C# Advanced";
            
        }
        public void Display_CourseStructure()
        {
            base.Display_Details();
            Console.WriteLine(Course_Basic);
            Console.WriteLine(Course_BasicPrg);
            Console.WriteLine(Course_Advanced);
            Console.WriteLine(Course_AdvancedPrg);
        }
    }

    internal class Inheritance
    {
        public static void Main()
        {
            //SINGLE-LEVEL
            //CourseDetails details = new CourseDetails();
            //details.GetDetails();
            //details.Display_Details();
            

            //MULTI-LEVEL
            CourseStructure courseStructure = new CourseStructure();
            courseStructure.GetDetails(); 
            //courseStructure.Display_Details();
            courseStructure.Get_CourseStructure();
            courseStructure.Display_CourseStructure();

            //courseStructure.Message();
            
            
        }
    }
}