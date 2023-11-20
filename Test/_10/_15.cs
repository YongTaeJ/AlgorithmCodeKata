using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
	internal class _15
	{
		public int solution(int n)
		{
			for(int i=1; i<n; i++)
			{
				if (n % i == 1)
					return i;
			}

			return -1;
		}
	}
}
