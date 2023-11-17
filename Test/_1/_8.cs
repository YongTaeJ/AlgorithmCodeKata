using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
	internal class _8
	{
		public int solution(int n)
		{
			if (n % 2 == 1)
				n--;

			return (2 + n) * n / 2 / 2;
		}
	}
}
