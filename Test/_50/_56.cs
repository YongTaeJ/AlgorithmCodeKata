using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
	internal class _56
	{
		public int solution(int k, int m, int[] score)
		{
			int[] scoreArr = new int[k]; // 0부터 k-1까지
			

			for(int i=0; i < score.Length; i++)
			{
				scoreArr[score[i]-1]++;
			}

			int length = score.Length;
			int sum = 0, currentStock, currentIdx = k-1; // idx + 1이 점수

			// 예외 주의!
			while(length >= m || currentIdx == -1)
			{
				currentStock = 0;
				while(currentStock != m)
				{
					if (scoreArr[currentIdx] == 0)
					{
						currentIdx--;
						continue;
					}
					scoreArr[currentIdx]--;
					currentStock++;
				}

				length -= m;
				sum += (currentIdx + 1) * m;
			}

			return sum;
		}
	}
}
