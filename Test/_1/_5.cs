using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
	internal class _5
	{
		public int solution(int num1, int num2)
		{
			int answer = 1;
			bool temp1, temp2;
			for(int i=0; i < 32; i++)
			{
				temp1 = Convert.ToBoolean(num1 % 2);
				temp2 = Convert.ToBoolean(num2 % 2);

				if(temp1 ^ temp2)
				{
					answer = -1;
				}

				num1 = num1 >> 1;
				num2 = num2 >> 1;
			}
			return answer;
		}
	}
}
