using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
	internal class _26
	{
		public int solution(int[] absolutes, bool[] signs)
		{
			int sum = 0;

			for(int i=0; i<absolutes.Length; i++)
			{
				int element = absolutes[i];
				if (!signs[i])
					element *= -1;
				sum += element;
			}

			return sum;
		}
	}
}
