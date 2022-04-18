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
            ForLoop();
            WhileLoop();
            doWhileLoop();
            EvenOdd();
            //Parameterised Method
            Square(2);
            EmpDetails(1, "John");
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
            //Relational(> < >= <= == !=) and Logical(&& || ^)
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
            coursecode =Convert.ToInt32(Console.ReadLine()); //100
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
        /// <summary>
        /// LOOPING STATEMENTS
        /// 1. ENTRY CONTROLLED - for,while
        /// 2. EXIT CONTROLLED - do-while
        /// </summary>
        public static void ForLoop()
        {
            Console.WriteLine("FOR LOOP");
            //Syntax
            for(int i = 0;i< 10; i++)
            {
                Console.WriteLine("The value is:{0}", i);
            }

        }
        /// <summary>
        /// WHILE LOOP
        /// </summary>
        public static void WhileLoop()
        {
            Console.WriteLine("WHILE LOOP");
            //Syntax
            int j=0;
            while(j<10)
            {
                Console.WriteLine("The value is:{0}", j);//0.....9
                j++;
            }

        }
        /// <summary>
        /// DO-WHILE
        /// </summary>
        public static void doWhileLoop()
        {
            Console.WriteLine("DO WHILE LOOP");
            //Syntax
            int k = 10;
            do
            {
                Console.WriteLine("The value is:{0}", k);//10
                k++;
            }while(k<10);

        }
        /// <summary>
        /// EVEN ODD PROGRAM
        /// </summary>
        public static void EvenOdd()
        {
            int number;
            Console.WriteLine("Enter the number");
            number = Convert.ToInt32(Console.ReadLine());
            if(number%2==0)
            {
                Console.WriteLine("Even Number");
            }
            else
            {
                Console.WriteLine("Odd Number");
            }

        }
        /// <summary>
        /// Square Functionality
        /// </summary>
        /// <param name="a"></param>
        public static void Square(int a)
        {
            int x;
            x = a * a;
            Console.WriteLine("Square is:{0}",x);
        }
        /// <summary>
        /// Employee Details
        /// </summary>
        /// <param name="EID"></param>
        /// <param name="EName"></param>
        public static void EmpDetails(int EID,string EName)
        {
            Console.WriteLine("Employee ID is:{0}", EID);
            Console.WriteLine("Employee Name is:{0}", EName);
        }
        

    }
}
