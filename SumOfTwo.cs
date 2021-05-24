using System;

namespace SumOfTwo
{
	class Program
	{
		public static void Main(string[] args)
		{
			//int a=10;
			//int b=20;
			//int c=a+b;
			int a,b;  
            		Console.WriteLine("Enter 1st number: ");  
            		a = Convert.ToInt32(Console.ReadLine());  
           		Console.WriteLine("Enter 2nd number: ");  
            		b = Convert.ToInt32(Console.ReadLine());  
            		int c;  
            		c = a+b;  
            		Console.WriteLine("Sum of two numbers is :" + c.ToString()); 
			//Console.WriteLine("Sum is {0}",c);
		}
	}
}