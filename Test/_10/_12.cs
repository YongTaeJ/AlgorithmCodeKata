using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
	internal class _12
	{
		public double solution(int[] arr)
		{
			double answer = 0;
			int length = arr.Length;
			for(int i=0; i < length; i++)
			{
				answer += arr[i];
			}
			answer /= length;
			return answer;
		}
	}
}
