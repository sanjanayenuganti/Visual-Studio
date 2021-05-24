using System;
namespace ThreeNums
{
	class Program
	{
		public static void Main(string[] args)
		{
			int x,y,z;  
            		Console.Write("Enter x value: ");  
            		x = Convert.ToInt32(Console.ReadLine());
			Console.Write("Enter y value: ");  
            		y = Convert.ToInt32(Console.ReadLine());
			Console.Write("Enter z value: ");  
            		z = Convert.ToInt32(Console.ReadLine());
			int a=(x+y)*z;
			int b=x*y+y*z;
			Console.WriteLine("(x+y)*z is: {0} ,x*y+y*z is: {1}",a,b);
		}
	}
}