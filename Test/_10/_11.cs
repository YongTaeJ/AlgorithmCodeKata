using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
	internal class _11
	{
		public string solution(int num)
		{
			string answer = "Odd";
			if (num % 2 == 0)
				answer = "Even";
			return answer;
		}
	}
}
