using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
	internal class _25
	{
		public int[] solution(int[] arr, int divisor)
		{
			List<int> list = new List<int>();
			int count = 0;

			for(int i=0; i<arr.Length; i++)
			{
				if (arr[i] % divisor == 0)
				{
					list.Add(arr[i]);
					count++;
				}
			}

			if (count == 0)
			{
				int[] aaa = { -1 };
				return aaa;
			}

			int[] answer = new int[count];

			for(int i=0; i<count ; i++)
			{
				answer[i] = list[i];
			}

			// answer의 값을 오름차순으로 정렬
			int min, minIdx, temp;
			for(int i=0; i<count; i++)
			{
				min = answer[i];
				minIdx = i;
				for(int j=i; j<count; j++)
				{
					// j~마지막 인덱스에 존재하는 최솟값을 도출
					if(min > answer[j])
					{
						minIdx = j;
						min = answer[j];
					}
				}
				temp = answer[i];
				answer[i] = answer[minIdx];
				answer[minIdx] = temp;
			}

			return answer;
		}
	}
}
