using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
	internal class _24
	{
		public string solution(string[] seoul)
		{
			int answerAdderss = 0;

			for(int i=0; i<seoul.Length; i++)
			{
				if (seoul[i] == "Kim")
					answerAdderss = i;
			}

			string answer = "김서방은 " + answerAdderss + "에 있다";
			return answer;
		}
	}
}
