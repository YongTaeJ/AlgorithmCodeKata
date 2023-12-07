using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
	internal class _62
	{
		public int solution(string[] babbling)
		{
			int answer = 0;
			int strIdx = 0;
			int answerCnt, currentAnswer;

			for(int i=0; i < babbling.Length; i++)
			{
				answerCnt = 1;
				strIdx = 0;
				// 0은 aya, 1은 ye, woo는 2, ma는 3
				currentAnswer = -1;
				while (strIdx < babbling[i].Length)
				{
					//a, y, w, m일 때 start.
					if(babbling[i][strIdx] == 'a' && strIdx+2 < babbling[i].Length && currentAnswer != 0)
					{
						if (babbling[i][strIdx + 1] == 'y' && babbling[i][strIdx + 2] == 'a')
						{
							currentAnswer = 0;
							strIdx += 3;
						}
						else
						{
							answerCnt = 0;
							break;
						}
					}
					else if (babbling[i][strIdx] == 'y' && strIdx + 1 < babbling[i].Length && currentAnswer != 1)
					{
						if (babbling[i][strIdx + 1] == 'e')
						{
							currentAnswer = 1;
							strIdx += 2;
						}
						else
						{
							answerCnt = 0;
							break;
						}
					}
					else if (babbling[i][strIdx] == 'w' && strIdx + 2 < babbling[i].Length && currentAnswer != 2)
					{
						if (babbling[i][strIdx + 1] == 'o' && babbling[i][strIdx + 2] == 'o')
						{
							currentAnswer = 2;
							strIdx += 3;
						}
						else
						{
							answerCnt = 0;
							break;
						}
					}
					else if (babbling[i][strIdx] == 'm' && strIdx + 1 < babbling[i].Length && currentAnswer != 3)
					{
						if (babbling[i][strIdx + 1] == 'a')
						{
							currentAnswer = 3;
							strIdx += 2;
						}
						else
						{
							answerCnt = 0;
							break;
						}
					}
					else
					{
						answerCnt = 0;
						break;
					}
				}
				answer += answerCnt;
			}

			return answer;
		}
	}
}
