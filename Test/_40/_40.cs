using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
	internal class _40
	{
		public int solution(int n)
		{
			int[] three = new int[17];
			int length = 0;
			int count = 0;

			// 자릿수를 담은 상태
			while(n != 0)
			{
				three[count] = n % 3;
				n /= 3;
				count++;
				if (n % 3 != 0)
					length = count;
			}

			int sum = 0;
			count = 1;
			for(int i=length; i>=0; i--, count *= 3)
			{
				sum += three[i] * count;
			}

			return sum;
		}

	}
}
