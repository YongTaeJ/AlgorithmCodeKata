using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
	internal class _7
	{
		public int solution(int angle)
		{
			int answer = 0;

			while(true)
			{
				if(angle/90 > 0)
				{
					angle -= 90;
					answer += 2;
				}
				else
				{
					break;
				}
			}
			if (angle % 90 > 0)
				answer++;

			return answer;
		}
	}
}
