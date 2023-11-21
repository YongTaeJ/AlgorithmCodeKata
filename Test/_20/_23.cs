using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
	internal class _23
	{
		public int solution(int num)
		{
			if (num == 1)
				return 0;

			// 캐스팅은 인터넷 보고 함. 
			long temp = num;

			int count = 0;

			// 0~499 500번, 횟수는 +1
			for (; count < 500; count++)
			{
				if (temp == 1)
					break;

				if (temp % 2 == 0)
					temp /= 2;
				else
					temp = temp * 3 + 1;
			}

			if (temp == 1)
				return count;
			else
				return -1;
		}
	}
}
