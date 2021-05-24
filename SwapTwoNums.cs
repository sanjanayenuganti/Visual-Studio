using System;
namespace SwapTwoNums
{
	class Program
	{
		public static void Main(string[] args)
		{
			int a,b;  
            		Console.Write("Enter 1st number: ");  
            		a = Convert.ToInt32(Console.ReadLine());
			Console.Write("Enter 2nd number: ");  
            		b = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Before Swapping: {0} , {1}",a,b);
			a=a^b;
			b=a^b;
			a=a^b;
			Console.WriteLine("After Swapping: {0} , {1}",a,b);
		}
	}
}