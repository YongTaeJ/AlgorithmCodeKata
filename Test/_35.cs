using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
	internal class _35
	{
		public long solution(int price, int money, int count)
		{
			long requiredMoney = 0;

			for(int i=0; i < count; i++)
			{
				requiredMoney += price * (i+1);
			}

			if(money > requiredMoney)
			{
				return 0;
			}
			else
			{
				return requiredMoney - money;
			}
		}
	}
}
