using System;
namespace Operations
{
	class Program
	{
		static int sum(int a, int b)
		{
			return a+b;
		}
		public static void Main(string[] args)
		{
			string sn1,sn2;
			int n1,n2,result;
			Console.Write("Enter num: ");
			sn1=Console.ReadLine();
			Console.Write("Enter num: ");
			sn2=Console.ReadLine();
			n1=Convert.ToInt32(sn1);
			n2=Convert.ToInt32(sn2);
			result=n1+n2;
			Console.WriteLine("{0} + {1} = {2}",n1,n2,result);
		}
	}
}