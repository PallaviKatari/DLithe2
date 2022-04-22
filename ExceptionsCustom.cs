using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Concepts
{
    /// <summary>
    /// STEP 1-Create a user-defined exception that inherits the base class EXCEPTION
    /// </summary>
    public class AttendanceTrackerException:Exception
    {
        public AttendanceTrackerException(string? message):base(message)
        {

        }
    }
    internal class ExceptionsCustom
    {
        public static void Main()
        {
            int trainees_count;
            try
            {
                Console.WriteLine("Attendance details on 22/04/2022");
                Console.WriteLine("Enter the number of trainees present today");//14
                trainees_count=Convert.ToInt32(Console.ReadLine());
                if(trainees_count<15&&trainees_count>15)
                {
                    throw (new AttendanceTrackerException("All are not present"));
                }
                else
                {
                    Console.WriteLine("All trainees are present");
                }

            }
            catch(AttendanceTrackerException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
}
