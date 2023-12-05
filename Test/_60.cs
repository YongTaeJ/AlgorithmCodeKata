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
			// 약수의 개수는 노가다?
			int answer = 0;
			int count;
			for(int i=1; i<=number; i++)
			{
				count = 0;
				for(int j=1; j<=i; j++)
				{
					if(i % j == 0)
						count++;
				}

				if (count <= limit)
					answer += count;
				else answer += power;
			}

			return answer;
		}
	}
}
