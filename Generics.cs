using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Concepts
{
    ///// <summary>
    ///// STAGE 1-CHECK EQUALITY-USING OBJECTS
    ///// </summary>
    //internal class Generics
    //{
    //    public static void Main()
    //    {
    //        //int-10,20-Value type
    //        bool result = Equality(10, "John"); //DISADVANTAGE-NO TYPE SAFETY
    //        if(result)
    //        {
    //            Console.WriteLine("EQUAL");
    //        }
    //        else
    //        {
    //            Console.WriteLine("NOT EQUAL");
    //        }


    //    }
    //    /// <summary>
    //    /// object - reference type
    //    /// int,float,char,bool- value type
    //    /// LEADS TO POOR PERFORMANCE
    //    /// Value type-Reference type-BOXING
    //    /// Reference type-Value type-UNBOXING
    //    /// </summary>
    //    /// <param name="a"></param>
    //    /// <param name="b"></param>
    //    /// <returns></returns>
    //    public static bool Equality(object a,object b)
    //    {
    //        return a == b;
    //    }
    //}

    /// <summary>
    /// STAGE 2-POLYMORPHISM-OVERCOME THE PROBLEMS FACED IN USING OBJECTS
    /// </summary>
    //public class POLYMORPHISM
    //{
    //    public static void Main()
    //    {
    //        //int-10,20-Value type
    //        bool result = Equality(10, 20);
    //        bool result1 = Equality(10.2f, 20.4f);
    //        if (result1)
    //        {
    //            Console.WriteLine("EQUAL");
    //        }
    //        else
    //        {
    //            Console.WriteLine("NOT EQUAL");
    //        }

    //    }
    //    /// <summary>
    //    /// int
    //    /// </summary>
    //    /// <param name="a"></param>
    //    /// <param name="b"></param>
    //    /// <returns></returns>
    //    public static bool Equality(int a,int b)
    //    {
    //        return a == b;
    //    }
    //    /// <summary>
    //    /// float
    //    /// </summary>
    //    /// <param name="a"></param>
    //    /// <param name="b"></param>
    //    /// <returns></returns>
    //    public static bool Equality(float a,float b)
    //    {
    //        return a == b;
    //    }
    //    /// <summary>
    //    /// double
    //    /// </summary>
    //    /// <param name="a"></param>
    //    /// <param name="b"></param>
    //    /// <returns></returns>
    //    public static bool Equality(double a, double b)
    //    {
    //        return a == b;
    //    }


    //}
    //public class Generics
    //{
    //    public static void Main()
    //    {
    //        //int-10,20-Value type
    //        //bool result = Equality<int,string>(10, "John");
    //        bool result = Equality<int>(10, 20);
    //        //bool result2 = Equality<float>(10.2f, 20.3f);
    //        //bool result3 = Equality<string>("John", "John");
    //        if (result)
    //        {
    //            Console.WriteLine("EQUAL");
    //        }
    //        else
    //        {
    //            Console.WriteLine("NOT EQUAL");
    //        }

    //    }
    //    /// <summary>
    //    /// Generic Type
    //    /// </summary>
    //    /// <param name="a"></param>
    //    /// <param name="b"></param>
    //    /// <returns></returns>

    //    public static bool Equality<T>(T a, T b)
    //    {
    //        return a.Equals(b);
    //    }
    //    //public static bool Equality<T,T1>(T a, T1 b)
    //    //{
    //    //    return a.Equals(b);
    //    //}
    //}

    //Generic Class
   class Generics1<T>
    { 
        //Generic Variable
        public T value; //100 John
        /// <summary>
        /// Generic Constructor with parameter as generic type
        /// </summary>
        /// <param name="value1"></param>
        public Generics1 (T value1) //100 John
        {
            this.value = value1;
        }
        /// <summary>
        /// Generic Method with return type and parameter as Generic Type 
        /// </summary>
        /// <param name="value2"></param>
        /// <returns></returns>
        public T Display(T value2) //public int Display(int value2) //200 Peter
        {
            Console.WriteLine("Value of the Generic Variable:{0}", value); //100 John
            Console.WriteLine("The type of the Generic Type:{0}",typeof(T).ToString());//int,string
            return value2;//200 Peter
        }
        

    }
    public class GenericsDemo
    {
        /// <summary>
        /// Calling the Generic Class
        /// </summary>
        public static void Main()
        {
            //int as the generic type
            Generics1<int> generics = new Generics1<int>(100);
            int result = generics.Display(200);//200
            Console.WriteLine("Value of value2:{0}",result);//200
            //string as the generic type
            Generics1<string> generics1 = new Generics1<string>("John");
            string result1 = generics1.Display("Peter");//Peter
            Console.WriteLine("Value of value2:{0}", result1);//Peter

        }
    }
}
