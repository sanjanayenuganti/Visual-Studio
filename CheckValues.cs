using System;
namespace CheckValues
{
	class Program
	{
		public static void Main(string[] args)
		{
			int a,b,c;  
            		Console.Write("Enter 1st number: ");  
            		a = Convert.ToInt32(Console.ReadLine());  
           		Console.Write("Enter 2nd number: ");  
            		b = Convert.ToInt32(Console.ReadLine());
			c = checkvalues(a,b);
			if(c == 1)
				Console.WriteLine("True");
			else
				Console.WriteLine("False");
		}
		static int checkvalues(int a, int b)
		{
			if(a*b==a+b || a*b==a-b && a*b==a/b)
				return 1;
			else
				return 0;
		}
	}
}	