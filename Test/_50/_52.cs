using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
	internal class _52
	{
		public int solution(int a, int b, int n)
		{
			// n개를 a개로 나눈 다음 b개 곱해서 줌
			int sum = 0;
			int left = 0;

			while(n > 0)
			{
				n += left;
				left = n % a;
				n = (n / a * b);
				sum += n;
			}
			return sum;
		}
	}
}
