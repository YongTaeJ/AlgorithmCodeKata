using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
	internal class _41
	{
		public string solution(string s)
		{
			StringBuilder sb = new StringBuilder();

			int count = 0;
			foreach (char c in s)
			{
				char temp = c;
				if(count % 2 == 1)
				{// 홀수번째 알파벳 -> 소문자로
					if (c >= 'A' && c <= 'Z')
					{
						temp = (char)(temp - 'A' + 'a');
						count++;
					}
					else if(c >= 'a' && c <= 'z')
					{
						count++;
					}
				}
				else
				{	// 짝수번째 알파벳 -> 대문자로
					if (c >= 'a' && c <= 'z')
					{
						temp = (char)(temp - 'a' + 'A');
						count++;
					}
					else if(c >= 'A' && c <= 'Z')
					{
						count++;
					}
				}

				if (temp == ' ')
					count = 0;

				sb.Append(temp);
			}

			return sb.ToString();
		}
	}
}
