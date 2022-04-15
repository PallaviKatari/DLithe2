using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Concepts
{
    internal class Arrays
    {
        /// <summary>
        /// ARRAY-COLLECTION OF ELEMENTS UNDER A SINGLE DATATYPE
        /// </summary>
        public static void Main()
        {
            //SINGLE DIMENSIONAL ARRAY
            int[] numbers=new int[] { 1, 2, 3, 4, 5};
            int[] numbers2 = new int[4] { 1, 2, 3, 4 };
            int[] numbers3 = { 1, 2, 3 };
            //looping through the elements in the array numbers
            foreach(int number in numbers)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine("*******************************");
            //looping through the elements in the array numbers2
            foreach (int number in numbers2)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine("*******************************");
            //looping through the elements in the array numbers3
            foreach (int number in numbers3)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine("*******************************");
            //Array random_numbers
            int[] random_numbers = { 77, 33, 56, 12, 7, 2, 5, 1 };
            //Array Methods
            Console.WriteLine(random_numbers.Min());
            Console.WriteLine(random_numbers.Max());
            Console.WriteLine(random_numbers.Average());
            Console.WriteLine(random_numbers.Count());
            Console.WriteLine(random_numbers.Length);
            Console.WriteLine(random_numbers.Sum());
            Console.WriteLine("Sorted Array");
            Array.Sort(random_numbers);
            Array.Reverse(random_numbers);
            foreach(int number in random_numbers)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine("*******************************");
            int size;
            Console.WriteLine("Enter the size of the array");
            size=Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[size];
            //Get the input from the user for the array arr
            for(int i=0; i<arr.Length; i++) //0<7 1<7 2<7 ... 7<7
            {
                Console.WriteLine("Enter the value {0}:", (i + 1)); //
                arr[i]=Convert.ToInt32(Console.ReadLine());
            }
            //Display the elements in the array arr
            Console.WriteLine("Elements in the array arr");
            foreach(int arrayelements in arr)
            {
                Console.WriteLine(arrayelements);
            }


        }
    }
}
