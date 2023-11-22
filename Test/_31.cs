using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
	internal class _31
	{
		public string solution(int n)
		{
			StringBuilder stringBuilder = new StringBuilder();

			for(int i=0; i<n; i++)
			{
				if(i % 2 == 1)
				{
					stringBuilder.Append("박");
				}
				else
				{
					stringBuilder.Append("수");
				}
			}

			return stringBuilder.ToString();
		}
	}
}
