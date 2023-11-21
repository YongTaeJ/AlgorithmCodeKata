using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
	internal class _29
	{
		public int[] solution(int[] arr)
		{ 
			int length = arr.Length;
			if(length <= 1)
			{
				int[] fail = { -1 };
				return fail;
			}

			int min = arr[0], minIdx = 0;
			for(int i=1; i< length; i++)
			{
				if(min > arr[i])
				{
					min = arr[i];
					minIdx = i;
				}
			}

			int[] answer = new int[length - 1];
			int bias = 0;

			// 최솟값 index를 무시한 나머지를 대입한다.
			for(int i=0; i< length; i++)
			{
				if(i == minIdx)
				{
					bias++;
					continue;
				}
				answer[i - bias] = arr[i];
			}

			return answer;
		}
	}
}
