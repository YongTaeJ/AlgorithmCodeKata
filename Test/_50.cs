using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
	internal class _50
	{
		public int[] solution(string s)
		{
			int[] alphabetLocation = new int[26];
			int[] answer = new int[s.Length];

			for(int i=0; i<26;i++)
			{
				alphabetLocation[i] = -1;
			}

			int location;
			// 현재 배열의 위치
			int count = 0;
			foreach(char alphabet in s)
			{
				location = (int)(alphabet - 'a');
				if (alphabetLocation[location] != -1)
				{
					// 배열에 거리를 계산하여 저장하고
					answer[count] = count - alphabetLocation[location];
				}
				else
				{
					// 배열에 -1을 저장
					answer[count] = -1;
				}
				// 현재 위치를 alphabetLocation에 저장
				alphabetLocation[location] = count++;
			}

			return answer;
		}
	}
}
