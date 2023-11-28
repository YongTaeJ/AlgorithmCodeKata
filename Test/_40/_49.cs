using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
	internal class _49
	{
		public int[] solution(int[] numbers)
		{
			// n.length-1이 시작점
			// length -> tryCnt이자 배열 length
			int length = (numbers.Length-1) * numbers.Length / 2;

			int[] tempArr = new int[length];
			int[] tryArr = new int[200];
			int count = 0;

			int temp;
			for(int i=0; i< numbers.Length-1; i++)
			{
				for(int j=i+1; j<numbers.Length; j++)
				{
					temp = numbers[i] + numbers[j];
					if (tryArr[temp] >= 1)
					{
						continue;
					}
					else
					{
						tryArr[temp]++;
						tempArr[count++] = temp;
					}
				}
			}

			int[] resultArr = new int[count];
			for(int i=0; i<count;i++)
			{
				resultArr[i] = tempArr[i];
			}

			// 정렬해서 return
			for(int i=count-1; i>=0; i--)
			{
				for(int j=0; j<i; j++)
				{
					if (resultArr[j] > resultArr[j+1])
					{
						temp = resultArr[j];
						resultArr[j] = resultArr[j + 1];
						resultArr[j+1] = temp;
					}
				}
			}

			return resultArr;
		}
	}
}
