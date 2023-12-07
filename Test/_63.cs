using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
	internal class _63
	{
		public string solution(string X, string Y)
		{
			StringBuilder answer = new StringBuilder();

			int[] XArr = new int[10];
			int[] YArr = new int[10];
			bool isNothing = true;

			foreach (char c in X) { XArr[(int)(c - '0')]++; }
			foreach (char c in Y) { YArr[(int)(c - '0')]++; }

			// arr에 동시에 존재한다면, 둘 다 차감하고 더하기 무한반복
			for(int i=9; i>=0; i--)
			{
				while(true)
				{
					if (XArr[i] != 0 && YArr[i] != 0)
					{
						answer.Append(i);
						XArr[i]--;
						YArr[i]--;
						isNothing = false;
					}
					else break;
				}
			}

			if (answer.Length != 0 && answer.ToString()[0] == '0')
				return "0";

			if (isNothing)
				return "-1";
			else
				return answer.ToString();
		}
	}
}
