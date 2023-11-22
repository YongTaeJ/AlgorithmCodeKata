using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
	internal class _33
	{
		public int solution(int left, int right)
		{
			int count;
			int answer = 0;
			for(int i=left; i <= right; i++)
			{
				count = 0;
				for(int j=1; j <= i; j++) // 1부터 현재값까지 약수 찾기
				{
					if(i % j == 0)
					{
						count++;
					}
				}
				if (count % 2 != 0) // 약수의 갯수가 홀수면
					answer -= i;
				else
					answer += i;
			}
			return answer;
		}
	}
}
