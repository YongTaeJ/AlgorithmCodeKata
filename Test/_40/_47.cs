using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
	internal class _47
	{
		public string[] solution(string[] strings, int n)
		{
			// 1. strings의 n번째 인덱스 확인
			// 2. 해당 index를 기준으로 하는 배열 생성 
			// 3. 오름차순 sort

			int len = strings.Length;
			char[] idxCharArr = new char[len];

			for(int i=0; i< len; i++)
			{
				idxCharArr[i] = strings[i][n];
			}

			int[] alphabetArr = new int[26];

			for(int i=0; i < len; i++)
			{
				alphabetArr[(int)(idxCharArr[i] - 'a')]++;
			}

			// n번째 index에 맞게 오름차순 정렬 
			char temp;
			string tmp;
			for(int i=len-1; i>=0; i--)
			{
				for(int j=0; j<i; j++)
				{
					if ( idxCharArr[j] > idxCharArr[j+1])
					{
						temp = idxCharArr[j];
						idxCharArr[j] = idxCharArr[j+1];
						idxCharArr[j + 1] = temp;
						tmp = strings[j];
						strings[j] = strings[j + 1];
						strings[j + 1] = tmp;
					}
				}
			}

			char target;
			int targetIdx = 0;

			string[] answer = strings;

			for (int i=0; i<26;i++)
			{
				if (alphabetArr[i] <= 1) continue;

				// 가장 처음 시작하는 targetIdx 찾기
				target = (char)('a' + i);
				for(int j=0; j<len;j++)
				{
					if (idxCharArr[j] == target)
					{
						targetIdx = j;
						break;
					}
				}

				// 들어있는 수만큼의 범위에서 order 진행
				// 이거 MSDN보고 따라함(원리 모름)
				IEnumerable<string> sortAscendingQuery =
					from str in strings
					where str[n] == target
					orderby str
					select str;

				foreach (string s in sortAscendingQuery)
				{
					answer[targetIdx++] = s;
				}
			}

			return answer;
		}
	}
}
