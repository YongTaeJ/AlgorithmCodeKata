using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
	internal class _53
	{
		public int[] solution(int k, int[] score)
		{
			// 최고점들을 기록하고, 그 중 최하위점을 출력하라
			int[] HallofFame = new int[k];
			int[] minArr = new int[score.Length];



			for(int i=0; i<k; i++)
			{
				HallofFame[i] = 2001;
			}

			for(int i=0; i<k;i++)
			{
				if (i >= score.Length) // 정답 보고 알았음;;
					continue;
				HallofFame[i] = score[i];
				minArr[i] = HallofFame.Min();
			}

			int minIdx = 0;
			int minvalue = HallofFame[0];

			for (int i = 0; i < k; i++)
			{
				if (minvalue > HallofFame[i])
				{
					minIdx = i;
					minvalue = HallofFame[i];
				}
			}

			for (int i=k; i < minArr.Length; i++)
			{
				if (score[i] <= minvalue)
				{
					// 바뀌는거 없음
				}
				else
				{
					// 최하점 자리에 현재 점수를 넣고, 다시 최하점 찾기
					HallofFame[minIdx] = score[i];
					minvalue = score[i];
					for (int j = 0; j < k; j++)
					{
						if (minvalue > HallofFame[j])
						{
							minIdx = j;
							minvalue = HallofFame[j];
						}
					}
				}
				minArr[i] = minvalue;
			}

			return minArr;
		}
	}
}
