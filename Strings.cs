using System;
using System.Collections.Generic;
using System.Linq;
using System.Text; //StringBuilder
using System.Threading.Tasks;

namespace CSharp_Concepts
{
    internal class Strings
    {
        public static void Main()
        {
            String_Demo();
            StringBuilder_Demo();
            
        }
        /// <summary>
        /// STRING DEMO
        /// </summary>
        public static void String_Demo()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("STRING DEMO");
            Console.ForegroundColor = ConsoleColor.White;
            //strings->immutable-cannot change
            //string->datatype/keyword
            string name = "John123"; //group of characters
            string course = "C# Programming";
            Console.WriteLine("Name is:{0}",name);
            Console.WriteLine("Course is:{0}", course);

            //character array
            char[] designation = { 'A', 'D', 'M', 'I', 'N' };
            //Pass the character array to String Class
            String des = new String(designation);
            Console.WriteLine("Designation passed to String class:{0}", des);
            //Pass the character  array to the string datatype
            string des1=new string(designation);
            Console.WriteLine("Designation passed to string datatype:{0}", des1);
            //Access character array using foreach loop
            foreach(char desig in designation)
            {
                Console.Write(desig); //ADMIN
            }
            Console.WriteLine();

            //Escape Sequence characters
            //\n-new line
            Console.WriteLine("Welcome to C# Programming\nHave a Nice Day!!!");
            //\t-tab space
            Console.WriteLine("Welcome to C# Programming\tHave a Nice Day!!!");
            //\" \'
            Console.WriteLine("\"Welcome to C# Programming\"\n\'Have a Nice Day!!!\'");
            // \\
            Console.WriteLine("\\\\CSharp\\Strings");
            //Verbatim Strings
            Console.WriteLine(@"\\CSharp\Strings");

        }
        /// <summary>
        /// STRING BUILDER CLASS
        /// </summary>
        public static void StringBuilder_Demo()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("STRING BUILDER DEMO");
            Console.ForegroundColor = ConsoleColor.White;

            StringBuilder sb = new StringBuilder("Hi Trainees!!!"); 
            Console.WriteLine(sb.ToString());

            //Append
            sb.Append(" Have a Nice Day!!!");
            Console.WriteLine(sb.ToString());

            //AppendLine
            sb.AppendLine(" Bye!!!");
            Console.WriteLine(sb.ToString());

            //Insert
            sb.Insert(15, "Welcome to C# Programming ");
            Console.WriteLine(sb.ToString());

            //Remove
            sb.Remove(3, 11);
            Console.WriteLine(sb.ToString());



        }
    }
}
