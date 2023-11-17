using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
	internal class _3
	{
		public int solution(int num1, int num2)
		{
			int count = 0;

			while(true)
			{
				if (num1 >= num2)
				{
					num1 -= num2;
					count++;
				}
				else
				{
					break;
				}
			}

			return count;

		}
	}
}
