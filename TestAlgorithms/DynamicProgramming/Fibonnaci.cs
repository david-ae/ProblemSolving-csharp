using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAlgorithms.DynamicProgramming
{
	public class Fibonnaci
	{
		private static Dictionary<int, int> memo = new Dictionary<int, int>();

		// recursive version
		public static int Fib(int number)
		{
			if (memo.ContainsKey(number)) return memo[number];
			if (number <= 2) return 1;

			memo[number] = Fib(number - 1) + Fib(number - 2);

			return memo[number];
		}
	}
}
