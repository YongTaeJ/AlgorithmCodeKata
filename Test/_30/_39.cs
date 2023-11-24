using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
	internal class _39
	{
		public int[] solution(int n, int m)
		{
			// 최대공약수
			int GCD = 1;
			for(int i=1; i<=n; i++)
			{
				if(n % i == 0)
				{
					if (m % i == 0)
						GCD = i;
				}
			}

			// 최소공배수

			int LCM = GCD * (n / GCD) * (m / GCD);

			int[] answer = new int[2];
			answer[0] = GCD;
			answer[1] = LCM;

			return answer;
		}
	}
}
