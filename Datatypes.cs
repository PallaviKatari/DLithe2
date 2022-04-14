using System; //Basic Namespace-Datatypes,Arrays,Strings,I/O etc
//COMMENT-CTRL+K+C
//UNCOMMENT-CTRL+K+U

//create a namespace
//Collection of classes

namespace DLithe2
{
    //Summary   
    /// <summary>
    /// Introduction to C# Datatypes
    /// </summary>

    public class DLithe_Batch2
    {
        //Functions->Methods

        /// <summary>
        /// Main Method
        /// </summary>
        public static void Main()
        {
            //System<-class.method
            Console.WriteLine("Welcome to C# Programming");

            //Datatypes

            //integer datatype
            int a = 7;
            //{0}-string formatter
            Console.WriteLine("Integer Value is:{0}", a);

            //float and double datatype
            float b = 3.14f;
            double c = 123.45678;
            Console.WriteLine("Float Value is:{0} and Double Value is:{1}", b, c);
            Console.WriteLine("Float Value is:{1} and Double Value is:{0}", c, b);
            Console.WriteLine("Float Value is:" + b);

            //string datatype
            string d = "DLithe2";
            //String Interpolation
            Console.WriteLine($"String Value is:{d}");

            //bool and char datatype
            bool e=true; 
            char f = 'A';
            Console.WriteLine($"Boolean value is:{e} and Character value is:{f}");

            //Typecasting and Type Conversion
            double g = 12.34;
            Console.WriteLine("Double Value is:{0}", g);
            int h = (int)g;
            Console.WriteLine("Double converted to int value:{0}", h);
            Console.WriteLine($"Convert the int value {h} to char" + Convert.ToChar(h));
            Console.WriteLine("Convert the given integer value to char"+Convert.ToChar(65));

            //Accept Trainee Details
            int TID;
            string TName;
            string TDes;
            Console.WriteLine("Enter the Trainee ID");//100
            //Accept Input- Console.ReadLine()
            TID =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Trainee Name and Designation");
            TName =Console.ReadLine();
            TDes =Console.ReadLine();
            //\n - newline
            Console.WriteLine($"The Trainee ID is {TID}.\nTrainee Name is {TName}.\nTrainee Designation is {TDes}");

        }
    }


}
