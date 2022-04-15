using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Concepts
{
    internal class NestedLoops
    {
		public static void Main()
		{ 
			Console.SetWindowSize(100, 50);
			// Printing the current dimensions
			Console.WriteLine("Window Width is:{0}",Console.WindowWidth);
			Console.WriteLine("Window Height is:{0}",Console.WindowHeight);
			Sample1();
			Sample2();
			Sample3();
			Sample4();
			Sample5();
			Sample6();
			
		}
		/// <summary>
		/// Working of Nested Loop
		/// </summary>
		public static void Sample1()
        {
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine("Sample 1");
			Console.ForegroundColor = ConsoleColor.White;
			int outerLoop = 0, innerLoop = 0;
			for (int i = 1; i <= 5; i++) //6<=5
			{
				outerLoop++; //5
				for (int j = 1; j <= 5; j++) //1<=5
				{
					innerLoop++;// 25
				}
			}
			Console.WriteLine("Outer Loop runs {0} times", outerLoop);//5
			Console.WriteLine("Inner Loop runs {0} times", innerLoop);//25

		}
		/// <summary>
		/// Nested Loop Numbers pattern(1 12 123 1234)- Here we display j
		/// </summary>
		public static void Sample2()
        {
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine("Sample 2");
			Console.ForegroundColor = ConsoleColor.White;
			//Outer Loop
			for (int i = 1; i <= 5; i++) //1<=5 2<=5 3<=5 4<=5 5<=5 6<=5
			{
				//Inner Loop
				for (int j = 1; j <= i; j++) //2<=1 3<=2 4<=3 1<=4 1<=5
				{
					Console.Write(j+" "); //displays in the same line
				}
				Console.WriteLine(); // new line after the inner loop terminates
			}
		}
		/// <summary>
		/// Nested While Loop
		/// </summary>
		public static void Sample3()
        {
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine("Sample 3");
			Console.ForegroundColor = ConsoleColor.White;
			int i = 0;
			while (i < 2) //0<2 1<2
			{
				int j = 0;
				while (j < 2) //Iteration 1->0<2 1<2  Iteration 2->0<2 1<2 
				{
					Console.Write("({0},{1}) ", i, j);
					//Iteration 1: (0,0) (0,1)
					//Iteration 2: (1,0) (1,1)
					j++; // j increments
				}
				i++; //i increments
				Console.WriteLine();
			}
		}
		/// <summary>
		/// Nested for loop for numbers (pattern 1 22 333 4444)
		/// Here we display i
		/// Replace i with *
		/// </summary>

		public static void Sample4()
        {
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine("Sample 4");
			Console.ForegroundColor = ConsoleColor.White;
			int i = 1;
			while (i <= 5)
			{
				for (int j = 1; j <= i; j++)
				{
					Console.Write(i + " ");
				}

				Console.WriteLine();
				i++;
			}
		}
		/// <summary>
		/// Nested For Loop for Multiplication Table
		/// </summary>
		public static void Sample5()
        {
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine("Sample 5");
			Console.ForegroundColor = ConsoleColor.White;
			int num;
			for (num = 1; num <= 5; num++)
			{
				Console.WriteLine("Table of " + num);
				for (int i = 1; i <= 10; i++)
					Console.WriteLine("{0}*{1}={2}", num, i, num * i);
			}
		}
		/// <summary>
		/// Working of Nested Loop 
		/// </summary>
		public static void Sample6()
        {
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine("Sample 6");
			Console.ForegroundColor = ConsoleColor.White;
			//  variable definition 
			int i, j;
			// Simple Nested for loop
			for (i = 1; i <= 12; i++)
			{
				for (j = 1; j <= 10; j++)
				{
					Console.Write(j + "  ");
				}
				Console.WriteLine("\t\t" + i);
			}
			Console.ReadLine();
		}
	}
}
