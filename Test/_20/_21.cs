using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
	internal class _21
	{
		public bool solution(int x)
		{
			// 자릿수로 나눠서 나머지가 0이면 true
			int originValue = x;
			bool answer = false;
			int digitSum = 0;

			while(true)
			{
				digitSum += x % 10;
				x /= 10;
				if (x == 0)
					break;
			}

			if (originValue % digitSum == 0)
				answer = true;

			return answer;

		}
	}
}
