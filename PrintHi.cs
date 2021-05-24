using System;

namespace PrintHi
{
	class Program
	{
		public static void Main(string[] args)
		{
			string ss;
			Console.Write("Enter the String: ");
			ss=Console.ReadLine();
			Console.WriteLine(ss+" "+ss+" "+ss+" "+ss);
			Console.WriteLine(ss+ss+ss+ss);
		}
	}
}