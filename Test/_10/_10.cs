using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
	internal class _10
	{
		public double solution(int[] numbers)
		{
			double answer = 0;

			for(int i=0; i < numbers.Length; i++)
			{
				answer += numbers[i];
			}

			answer /= numbers.Length;

			return answer;
		}
	}
}
