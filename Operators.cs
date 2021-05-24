using System;
namespace Operators
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
			int addn=a+b;
			int subn=a-b;
			int muln=a*b;
			int divn=a/b;
            		Console.WriteLine("Addition of two numbers is : {0}",addn);
			Console.WriteLine("Subtracion of two numbers is : {0}",subn);
			Console.WriteLine("Multiplication of two numbers is : {0}",muln);
			Console.WriteLine("Division of two numbers is : {0}",divn);
		}
	}
}