using System;

namespace Absvalue
{
	class Program
	{
		public static void Main(string[] args)
		{
			int n;
			Console.Write("Enter the number: ");
			n=Convert.ToInt32(Console.ReadLine());
			int a=Math.Abs(n);
			Console.WriteLine("Abs Value is: "+a);
		}
	}
}