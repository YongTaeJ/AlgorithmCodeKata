using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
	internal class _34
	{
		public string solution(string s)
		{
			int length = s.Length;
			StringBuilder sb = new StringBuilder();

			char max = ' ';
			int maxIdx = 0;

			for (int i = length-1; i >= 0 ; i--)
			{
				max = s[0];
				maxIdx = 0;
				for(int j = 0; j <= i; j++) // 큰 수 보내기
				{
					if (s[j] > max)
					{
						max = s[j];
						maxIdx = j;
					}
				}
				sb.Append(max);
				s = s.Remove(maxIdx, 1);
			}

			return sb.ToString();
		}
	}
}
