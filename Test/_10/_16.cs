using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
	internal class _16
	{
		public long[] solution(int x, int n)
		{
			long[] arr = new long[n];

			for (int i = 0; i < n; i++)
			{
				arr[i] = (long) x * (1 + i);
			}

			return arr;
		}
	}
}
