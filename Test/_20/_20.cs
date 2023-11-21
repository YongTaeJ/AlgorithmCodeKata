using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
	internal class _20
	{
		public long solution(long n)
		{
			long[] arr = new long[10];

			while(true)
			{
				arr[n % 10]++;

				n /= 10;
				if (n == 0)
					break;
			}

			long sum = 0;

			for(int i=9; i>=0; i--)
			{
				while(true)
				{
					if (arr[i] == 0)
						break ;
					sum = (sum * 10) + i;
					arr[i]--;
				}
			}

			return sum;
		}
	}
}
