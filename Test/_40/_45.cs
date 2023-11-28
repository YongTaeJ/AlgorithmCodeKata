using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
	internal class _45
	{
		public string solution(string s, int n)
		{

			// a가 1이면 z는 26
			StringBuilder stringBuilder = new StringBuilder();
			char tempChar;

			foreach (char c in s)
			{
				if( (c >= 'a' && c <= 'z') )
				{
					if (c + n > 'z')
						tempChar = (char)(c + n - 26);
					else
						tempChar = (char)(c + n);
				}
				else if((c >= 'A' && c <= 'Z'))
				{
					if (c + n > 'Z')
						tempChar = (char)(c + n - 26);
					else
						tempChar = (char)(c + n);
				}
				else
				{
					tempChar = c;
				}
				stringBuilder.Append(tempChar);
			}

			return stringBuilder.ToString();
		}
	}
}
