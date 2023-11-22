using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
	internal class _32
	{
		public int solution(int[] a, int[] b)
		{
			int length = a.Length;
			int sum = 0;

			for(int i=0; i<length; i++)
			{
				sum += a[i] * b[i];
			}

			return sum;
		}
	}
}
