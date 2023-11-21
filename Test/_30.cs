using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
	internal class _30
	{
		public string solution(string s)
		{
			int stock = s.Length;
			string answer;

			if (stock % 2 == 0)
			{
				answer = s.Substring(stock / 2 - 1, 2);
			}
			else
			{
				answer = s.Substring(stock / 2, 1);
			}

			return answer;
		}
	}
}
