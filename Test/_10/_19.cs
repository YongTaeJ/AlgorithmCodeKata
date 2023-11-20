using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
	internal class _19
	{
		public long solution(long n)
		{
			long count = 1;

			for (; count * count <= n; count++)
			{
				if (count * count == n)
				{
					count++;
					return count * count;
				}
			}

			return -1;
		}
	}
}
