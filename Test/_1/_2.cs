using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
	public class _2
	{
		public int solution(int num1, int num2)
		{
			int answer = 0;
			for (int i = 0; i < num2; i++)
			{
				answer += num1;
			}
			return answer;
		}
	}
}
