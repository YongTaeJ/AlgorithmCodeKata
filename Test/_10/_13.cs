using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
	internal class _13
	{
		public int solution(int n)
		{
			int answer = 0;
			while(n != 0)
			{
				answer += n % 10;
				n /= 10;
			}
			return answer;
		}
	}
}
