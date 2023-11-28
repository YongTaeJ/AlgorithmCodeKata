using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
	internal class _44
	{
		public int solution(int[,] sizes)
		{
			// 큰 쪽을 전부 x로 몰아버린 다음

			int x = sizes.GetLength(0);
			int temp;

			for(int i=0; i < x; i++)
			{
				if (sizes[i,0] <= sizes[i,1])
				{
					temp = sizes[i, 0];
					sizes[i, 0] = sizes[i, 1];
					sizes[i, 1] = temp;
				}
			}

			int xMax = sizes[0, 0];
			int yMax = sizes[0, 1];

			for(int i=0; i<x; i++)
			{
				if(xMax < sizes[i,0])
				{
					xMax = sizes[i, 0];
				}
				
				if(yMax < sizes[i,1])
				{
					yMax = sizes[i, 1];
				}
			}

			return xMax * yMax;
		}
	}
}
