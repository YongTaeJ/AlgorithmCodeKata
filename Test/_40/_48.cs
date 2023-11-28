using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
	internal class _48
	{
		public int[] solution(int[] array, int[,] commands)
		{
			int tryCount = commands.GetLength(0);
			int startIdx, endIdx, findIdx;
			int[] tempArr;
			int[] answer = new int[tryCount];

			for (int i=0; i<tryCount; i++)
			{
				startIdx = commands[i,0];
				endIdx = commands[i,1];
				findIdx = commands[i,2];

				tempArr = new int[endIdx - startIdx + 1];
				int count = 0;
				// s~e까지 자르고, 정렬한 뒤, 그 중에서 find!
				for(int j = startIdx-1; j < endIdx ; j++)
				{
					tempArr[count++] = array[j];
				}

				int temp;
				for(int j=count-1; j>=0; j--)
				{
					for(int k=0; k<j; k++)
					{
						if (tempArr[k] > tempArr[k+1])
						{
							temp = tempArr[k];
							tempArr[k] = tempArr[k + 1];
							tempArr[k + 1] = temp;
						}
					}
				}
				answer[i] = tempArr[findIdx - 1];
			}

			return answer;

		}
	}
}
