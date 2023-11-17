using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
	internal class _6
	{
		public int solution(int num1, int num2)
		{
			int count = 0;
			int sum = num1 << 8 + num1 << 7 + num1 << 6 + num1 << 5 + num1 << 3;

			while(true)
			{
				if(sum >= num2)
				{
					sum -= num2;
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
