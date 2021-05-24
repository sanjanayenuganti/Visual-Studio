using System;
namespace AvgOfNums
{
	class Program
	{
		public static void Main(string[] args)
		{
			double a1,a2,a3,a4; 
            		Console.Write("Enter 1st number: ");  
            		a1 = Convert.ToDouble(Console.ReadLine());
			Console.Write("Enter 2nd number: ");  
            		a2 = Convert.ToDouble(Console.ReadLine());
			Console.Write("Enter 3rd number: ");  
            		a3 = Convert.ToDouble(Console.ReadLine());
			Console.Write("Enter 4th number: ");  
            		a4 = Convert.ToDouble(Console.ReadLine());
			double avg=(a1+a2+a3+a4)/4;
			Console.WriteLine("Avg of 4 numbers is: {0}",avg);
		}
	}
}