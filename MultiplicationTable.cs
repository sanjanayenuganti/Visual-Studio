using System;
namespace MultiplicationTable
{
	class Program
	{
		public static void Main(string[] args)
		{
			int x,result;  
            		Console.Write("Enter a number: ");  
            		x = Convert.ToInt32(Console.ReadLine());
			//for(i=1;i<=10;i++)
			//{
			//	Console.WriteLine("{0} x {1} = {2}",n,i,n*i);
			//}
			result = x * 1;
  			Console.WriteLine("{0} x {1} = {2}", x, 1, result);
  			result = x * 2;
  			Console.WriteLine("{0} x {1} = {2}", x, 2, result);
  			result = x * 3;
  			Console.WriteLine("{0} x {1} = {2}", x, 3, result);
  			result = x * 4;
  			Console.WriteLine("{0} x {1} = {2}", x, 4, result);
  			result = x * 5;
  			Console.WriteLine("{0} x {1} = {2}", x, 5, result);
  			result = x * 6;
  			Console.WriteLine("{0} x {1} = {2}", x, 6, result);
  			result = x * 7;
  			Console.WriteLine("{0} x {1} = {2}", x, 7, result);
  			result = x * 8;
  			Console.WriteLine("{0} x {1} = {2}", x, 8, result);
  			result = x * 9;
  			Console.WriteLine("{0} x {1} = {2}", x, 9, result);
  			result = x * 10;
  			Console.WriteLine("{0} x {1} = {2}", x, 10, result);
		}
	}
}