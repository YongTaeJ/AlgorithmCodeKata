using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
	internal class _22
	{
		public long solution(int a, int b)
		{
			long answer = 0;
			int min, max;
			if(a >= b)
			{
				max = a;
				min = b;
			}
			else
			{
				max = b;
				min = a;
			}

			for(int i = min; i <= max; i++)
			{
				answer += i;
			}

			return answer;
		}
	}
}
