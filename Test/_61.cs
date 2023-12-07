using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
	internal class _61
	{
		public int[] solution(int[] lottos, int[] win_nums)
		{
			int[] answer = new int[2];

			int answerCount = 0;
			int zeroCount = 0;
			int lottosCount = 0;
			bool isMatch = false;

			while (lottosCount != 6)
			{

				if (lottos[lottosCount] == 0)
				{
					zeroCount++;
					lottosCount++;
					continue;
				}

				isMatch = false;

				for (int i = 0; i < 6; i++)
				{
					if (lottos[lottosCount] == win_nums[i])
					{
						isMatch = true;
					}
				}

				if (isMatch) answerCount++;
				lottosCount++;
			}

			if (answerCount < 2) answer[1] = 6;
			else answer[1] = 7 - answerCount;

			if (answerCount + zeroCount < 2) answer[0] = 6;
			else answer[0] = 7 - (answerCount + zeroCount);

			return answer;
		}
	}
}
