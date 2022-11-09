using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1_Int32.IsOdd__IsEven
{
	internal class Program
	{
		static void Main(string[] args)
		{

		}
	}
	public static class Judge 
	{
		public static bool isOdd(this int num)
		{
			if (num % 2 == 1) 
			{
				return true; 
			}
			else 
			{ 
				return false; 
			}
			
		}
		public static bool IsEven(this int num)
		{
			if (num % 2 == 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

	}
	
}
