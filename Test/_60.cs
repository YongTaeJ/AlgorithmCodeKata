using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
	internal class _60
	{
		public int solution(int number, int limit, int power)
		{
			int answer = 0;

			int count;

			for (int i = 1; i <= number; i++)
			{
				int j;
				count = 0;

				for (j = 1; j * j <= i; j++)
				{
					if (i % j == 0)
					{
						count++;
					}
				}
				count *= 2;
				if ((j - 1) * (j - 1) == i) count--;

				if (count > limit) answer += power;
				else answer += count;
			}

			return answer;
		}
	}
}
