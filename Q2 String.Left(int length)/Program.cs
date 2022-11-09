using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2_String.Left_int_length_
{
	internal class Program
	{
		static void Main(string[] args)
		{
			
		}
	}
	public static class String
	{
		public static string Left(this string value,int length)
		{ 
			if (string.IsNullOrEmpty(value)) 
			{
				value = string.Empty;
				return value;
			}
			if (value.Length > length)
			{
				value = value.Substring(0, length);
				return value;
			}
			if (value.Length <= length)
			{
				return value;
			}
			else
			{
				value = string.Empty;
				return value;
			}
		}

	}
}
