using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
	internal class _28
	{
		public int solution(int[] numbers)
		{
			int answer = (1 + 9) * 9 / 2;

			for(int i=0; i<numbers.Length; i++)
			{
				answer -= numbers[i];
			}

			return answer;
		}
	}
}
