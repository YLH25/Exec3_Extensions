using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string string1 = "abc";
			int num = string1.ToInt(1);
			Console.WriteLine(num);

			string string2 = "123";
			int num2 = string2.ToInt(1);
			Console.WriteLine(num2);
		}
	}
	public static class String
	{
		public static int ToInt(this string value, int defaultValue)
		{
			bool canBeInt = int.TryParse(value, out int result);
			return (canBeInt)? result : defaultValue;
		}
	}
}
