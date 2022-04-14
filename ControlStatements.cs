using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Concepts
{
    /// <summary>
    /// CONTROL STATEMENTS
    /// 1. Conditional Statements
    /// 2. Looping Statements
    /// </summary>
    internal class ControlStatements
    {
        /// <summary>
        /// Main Method accessing static methods
        /// </summary>
        public static void Main()
        {
            //creating an instance/object in c#
            //Classname instance=new Classname();
            ControlStatements controlStatements = new ControlStatements();
            //static method is called/invoked
            Conditionalif();
            //instance method is called/invoked
            controlStatements.Conditionalswitch();

        }
        /// <summary>
        /// static method - cn be accessed directly from the Main method 
        /// Conditional Statements
        /// 1. if-else -> simple if,if-else,else if, nested if
        /// 2. switch-case -> multiple conditions on a single variable
        /// </summary>
        public static void Conditionalif()
        {
            //if-else - greatest of 3 numbers
            //Relational and Logical Operators
            int a = 10;
            int b = 20;
            int c = 30;
            //Relational and Logical
            //if((a>b)&&(a>c)) //&& - AND
            //{
            //    Console.WriteLine("A is the greatest");
            //}
            //Nested if
            if(a>b)
            {
                //simple if - no else block
                if(a>c)
                {
                    Console.WriteLine("A is the greatest");
                }
            }
            //else if
            else if(b>c)
            {
                Console.WriteLine("B is the greatest");
            }
            else
            {
                Console.WriteLine("C is the greatest");
            }

        }
        /// <summary>
        /// instance method
        /// switch-case
        /// </summary>
        public void Conditionalswitch()
        {
            int coursecode;
            Console.WriteLine("Enter the Course Code");
            coursecode =Convert.ToInt32(Console.ReadLine());
            switch(coursecode)
            {
                case 100:
                         Console.WriteLine("C# Programming");
                         break;
                case 101:
                        Console.WriteLine("Java Programming");
                        break;
                case 102:
                        Console.WriteLine("Python Programming");
                        break;
                default:
                        Console.WriteLine("Course not found");
                        break;

            }

        }
        
    }
}
