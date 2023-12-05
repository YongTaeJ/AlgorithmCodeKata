using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
	internal class _57
	{
		public int[] solution(int[] answers)
		{
			int[] mathThrow1 = { 1, 2, 3, 4, 5 };
			int[] mathThrow2 = { 2,1,2,3,2,4,2,5 };
			int[] mathThrow3 = { 3,3,1,1,2,2,4,4,5,5 };

			int idx1 = 0, idx2 = 0, idx3 = 0;
			int[] answerCount = { 0, 0, 0};

			int temp = 0;
			for(int i=0; i<answers.Length; i++)
			{
				temp = answers[i];

				if (mathThrow1[idx1] == temp) answerCount[0]++;
				if (mathThrow2[idx2] == temp) answerCount[1]++;
				if (mathThrow3[idx3] == temp) answerCount[2]++;

				idx1 = (idx1 + 1) % 5;
				idx2 = (idx2 + 1) % 8;
				idx3 = (idx3 + 1) % 10;
			}

			// answer의 최댓값을 찾은 뒤 
			int maxValue = 0;
			for(int i=0; i<3; i++ )
			{
				if (answerCount[i] > maxValue)
				{
					maxValue = answerCount[i];
				}
			}

			temp = 0;
			for(int i=0; i<3;i++)
			{
				if (answerCount[i] ==  maxValue)
				{
					temp++;
				}
			}

			int[] myAnswer = new int[temp];
			temp = 0;

			for (int i = 0; i < 3; i++)
			{
				if (answerCount[i] == maxValue)
				{
					myAnswer[temp++] = i + 1;
				}
			}

			return myAnswer;
		}
	}
}
