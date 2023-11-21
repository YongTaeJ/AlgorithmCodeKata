using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
	internal class _27
	{
		public string solution(string phone_number)
		{
			int starStock = phone_number.Length - 4;

			string answer = null;
			for(int i=0; i<starStock; i++)
			{
				answer += '*';
			}
			return answer + phone_number.Substring(starStock);
		}
	}
}
