using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
	internal class _17
	{
		public int[] solution(long n)
		{
			// 자릿수 검증
			int[] tempArr = new int[11];
			int digitCount = 0;
			int digitNumber = 0;

			while (true)
			{
				digitNumber = (int)(n % 10);
				tempArr[digitCount] = digitNumber;
				n /= 10;
				digitCount++;
				if (n == 0)
				{
					break;
				}
			}

			int[] arr = new int[digitCount];

			for (int i = 0; i < digitCount; i++)
			{
				arr[i] = tempArr[i];
			}

			return arr;
		}
	}
}
