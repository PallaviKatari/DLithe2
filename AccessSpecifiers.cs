using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Concepts
{
    /// <summary>
    /// public,private,protected(inheritance),internal,protected internal 
    /// </summary>
    public class AccessSpecifiers
    {
        //private variables
        public int id;
        public string name;
        /// <summary>
        /// Encapsulation
        /// Properties-
        /// </summary>
        public int Id
        {
            get { return id; } //read
            set { id = value; } //write 10
        }
        public string Name
        {
            get { return name; }
            set { name = value; } //write
        }
        public void Display()
        {
            Console.WriteLine($"ID is {id} and Name is {name}");
        }
    }
    public class Encapsulation
    {
        public static void Main()
        {
            AccessSpecifiers accessSpecifiers = new AccessSpecifiers();
            accessSpecifiers.Id = 10; //write
            Console.WriteLine("ID is:{0}",accessSpecifiers.Id); //read
            accessSpecifiers.Name = "John"; //write
            Console.WriteLine("Name is:{0}", accessSpecifiers.Name); //read(cannot)
            accessSpecifiers.Display();
        }
    }
}
